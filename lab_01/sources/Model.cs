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

        public Font dotFont = new Font("Arial", 8);
        public SolidBrush brush = new SolidBrush(Color.Red);

        private int dotRadius = 2;

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

            brush.Color = circlePen.Color;
            for (int i = 0; i < 3; i++)
            {
                DrawDot(g, circlePen, new SolidBrush(circlePen.Color), _firstCircle.dotsSet[i], converter);
            }
            
            tempConvertedDot = converter.ConvertDot(_secondCircle.centre);
            newRadius = converter.ConvertSize((float)_secondCircle.radius);
            g.DrawEllipse(circlePenSecond, tempConvertedDot.X - newRadius, tempConvertedDot.Y - newRadius,
                                     newRadius * 2, newRadius * 2);

            brush.Color = circlePenSecond.Color;
            for (int i = 0; i < 3; i++)
            {
                DrawDot(g, circlePenSecond, brush, _secondCircle.dotsSet[i], converter);
            }

            brush.Color = quadranglePen.Color;
            g.DrawPolygon(quadranglePen, _currentQuadrangle.points.Select(x => converter.ConvertDot(x)).ToArray());
            for (int i = 0; i < 4; i++)
            {
                DrawDot(g, quadranglePen, brush, _currentQuadrangle.points[i], converter);
            }

            tempConvertedDot = converter.ConvertDot(_currentTangent.first);
            PointF secondTempConvDot = converter.ConvertDot(_currentTangent.second);

            g.DrawLine(tangetPen, tempConvertedDot, secondTempConvDot);
        }


        private void DrawDot(Graphics g, Pen pen, Brush brush, PointF dot, Converter converter)
        {
            PointF preProcessPoint = new PointF((float)Math.Round(dot.X, 3), (float)Math.Round(dot.Y, 3));

            g.DrawString(FormatDot(preProcessPoint),
                         dotFont, brush, converter.ConvertDotOffset(dot));

            dot = converter.ConvertDot(dot);

            pen.Width = 5;
            g.DrawEllipse(pen, dot.X - dotRadius, dot.Y - dotRadius, dotRadius * 2, dotRadius * 2);
            pen.Width = 1;
        }

        public string FormAnswer()
        {
            return String.Format("Круг из первого множества (красный) построен на точках \r\n{0}, {1}, {2}. Центр: {3}. Радиус: {4}\r\n" +
                         "Круг из второго множества (зеленый) построен на точках \r\n{5}, {6}, {7}. Центр: {8}. Радиус: {9}\r\n\r\n" +
                         "Четырех угольник построен на центрах окружностях и точках касания общей касательной {10} и {11}. Площадь: {12}",
                         FormatDot(_firstCircle.dotsSet[0]), FormatDot(_firstCircle.dotsSet[1]), FormatDot(_firstCircle.dotsSet[2]),
                         FormatDot(_firstCircle.centre), Math.Round(_firstCircle.radius, 3).ToString(),
                         FormatDot(_secondCircle.dotsSet[0]), FormatDot(_secondCircle.dotsSet[1]), FormatDot(_secondCircle.dotsSet[2]),
                         FormatDot(_secondCircle.centre), Math.Round(_secondCircle.radius, 3).ToString(),
                         FormatDot(_currentTangent.first), FormatDot(_currentTangent.second), Math.Round(_currentQuadrangle.Square, 3).ToString());
        }

        private string FormatDot(PointF point)
        {
            return String.Format("({0}, {1})", Math.Round(point.X, 3).ToString(), Math.Round(point.Y, 3).ToString());
        }
    }

}
