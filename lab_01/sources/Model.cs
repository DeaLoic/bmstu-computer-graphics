using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab_01
{
    class Model
    {

        private List<PointF> _firstSet;
        private List<PointF> _secondSet;

        private PointF _minCoords;
        private PointF _maxCoords;

        private List<Circle> _firstCircles = null;
        private List<Circle> _secondCircles = null;

        private Circle _firstCircle = null;
        private Circle _secondCircle = null;
        private Section _currentTangent = null;

        private Quadrangle _currentQuadrangle = null;
        private double _currentSquare = 0;

        public Pen circlePen = new Pen(Color.Red, 1);
        public Pen circlePenSecond = new Pen(Color.Green, 1);
        public Pen tangetPen = new Pen(Color.Black, 1);
        public Pen quadranglePen = new Pen(Color.Blue, 1);

        public Model()
        {

        }
        public Model(List<PointF> firstSet, List<PointF> secondSet)
        {
            SetDots(firstSet, secondSet);
        }

        private void Reset()
        {
            _firstSet = null;
            _secondSet = null;

            _firstCircles = null;
            _secondCircles = null;

            _firstCircle = null;
            _secondCircle = null;
            _currentTangent = null;

            _currentQuadrangle = null;
            _currentSquare = 0;
        }

        public void SetDots(List<PointF> firstSet, List<PointF> secondSet)
        {
            Reset();

            _firstSet = firstSet;
            _secondSet = secondSet;

            FormModel();
        }

        public string ErrorMessage
        {
            get
            {
                string message = "";
                if (_firstCircles is null || _firstCircles.Count == 0)
                {
                    message += "Невозможно построить ни один круг из точек первого множества.\n";
                }
                if (_secondCircles is null || _secondCircles.Count == 0)
                {
                    message += "\nНевозможно построить ни один круг из точек второго множества.\n";
                }
                if (message == "")
                {
                    if (_currentQuadrangle is null)
                    {
                        message += "Невозможно построить четырехугольник\n" +
                                   "(у всех кругов только одна общая касательная или их нет совсем).\n";
                    }
                }
                

                return message;
            }
        }

        public bool IsCorrect
        {
            get
            {
                return !(_currentQuadrangle is null);
            }
        }

        private void FormModel()
        {
            _firstCircles = FormCircles(_firstSet);
            _secondCircles = FormCircles(_secondSet);

            if ((_firstCircles?.Count ?? 0) >= 1 && (_secondCircles?.Count ?? 0) >= 1)
            {
                for (int i = 0; i < _firstCircles.Count; i++)
                {
                    for (int k = 0; k < _secondCircles.Count; k++)
                    {
                        Circle tempFirstCircle = _firstCircles[i];
                        Circle tempSecondCircle = _secondCircles[k];
                        List<Section> generalTangents = _firstCircles[i].GeneralTangents(_secondCircles[k]);
                        for (int j = 0; j < generalTangents.Count; j++)
                        {
                            Quadrangle temp = new Quadrangle(new Section(generalTangents[j].first, tempFirstCircle.centre),
                                                             new Section(generalTangents[j].second, tempSecondCircle.centre));
                            if ((_currentQuadrangle?.Square ?? 0) < temp.Square)
                            {
                                _firstCircle = _firstCircles[i];
                                _secondCircle = _secondCircles[k];
                                _currentTangent = generalTangents[j];

                                _currentQuadrangle = temp;
                                _currentSquare = _currentQuadrangle.Square;
                            }
                        }
                    }
                }
            }

            SetMinMaxCoords();
        }

        private List<Circle> FormCircles(List<PointF> points)
        {
            List<Circle> circles = new List<Circle>();

            if (!(points is null) && points.Count >= 3)
            {
                for (int i = 0; i < points.Count - 2; i++)
                {
                    for (int j = i + 1; j < points.Count - 1; j++)
                    {
                        for (int k = j + 1; k < points.Count; k++)
                        {
                            Circle newCircle = new Circle(points[i], points[j], points[k]);
                            if (newCircle.isCorrect)
                            {
                                circles.Add(newCircle);
                            }
                        }
                    }
                }
            }

            return circles;
        }

        private void SetMinMaxCoords()
        {
            if (IsCorrect)
            {
                PointF firstCentre = _firstCircle.centre;
                PointF secondCentre = _secondCircle.centre;

                double firstRadius = _firstCircle.radius;
                double secondRadius = _secondCircle.radius;

                _minCoords.X = (float)Math.Min(firstCentre.X - firstRadius, secondCentre.X - secondRadius);
                _minCoords.Y = (float)Math.Min(firstCentre.Y - firstRadius, secondCentre.Y - secondRadius);

                _maxCoords.X = (float)Math.Max(firstCentre.X + firstRadius, secondCentre.X + secondRadius);
                _maxCoords.Y = (float)Math.Max(firstCentre.Y + firstRadius, secondCentre.Y + secondRadius);
            }
        }

        public void Draw(Graphics g, Size areaSize, int indent = 20)
        {
            Converter converter = new Converter(_minCoords, _maxCoords, areaSize, indent);

            PointF tempConvertedDot = converter.ConvertDot(_firstCircle.centre);
            float newRadius = converter.ConvertSize((float)_firstCircle.radius);
            g.DrawEllipse(circlePen, tempConvertedDot.X - newRadius, tempConvertedDot.Y - newRadius,
                                     newRadius * 2, newRadius * 2);
            /*
            g.DrawEllipse(circlePen, new Rectangle((int)tempConvertedDot.X, (int)tempConvertedDot.Y,
                                                   (int)_firstCircle.radius, (int)_firstCircle.radius));

            */
            tempConvertedDot = converter.ConvertDot(_secondCircle.centre);
            newRadius = converter.ConvertSize((float)_secondCircle.radius);
            g.DrawEllipse(circlePenSecond, tempConvertedDot.X - newRadius, tempConvertedDot.Y - newRadius,
                                     newRadius * 2, newRadius * 2);


            g.DrawPolygon(quadranglePen, _currentQuadrangle.points.Select(x => converter.ConvertDot(x)).ToArray());

            
            tempConvertedDot = converter.ConvertDot(_currentTangent.first);
            PointF secondTempConvDot = converter.ConvertDot(_currentTangent.second);

            g.DrawLine(tangetPen, tempConvertedDot, secondTempConvDot);
        }
    }
}
