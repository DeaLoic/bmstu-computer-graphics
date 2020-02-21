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

        private List<Circle> _firstCircles = null;
        private List<Circle> _secondCircles = null;

        private Circle _firstCircle = null;
        private Circle _secondCircle = null;
        private Section _currentTangent = null;

        private Quadrangle _currentQuadrangle = null;
        private double _currentSquare = 0;

        public Pen circlePen = new Pen(Color.Red, 1);
        public Pen tangetPen = new Pen(Color.Black, 1);
        public Pen quadranglePen = new Pen(Color.Blue, 1);

        public Model(List<PointF> firstSet, List<PointF> secondSet)
        {
            this._firstSet = firstSet;
            this._secondSet = secondSet;

            this._firstCircles = FormCircles(firstSet);
            this._secondCircles = FormCircles(secondSet);

            FormModel();
        }

        public string ErrorMessage
        {
            get
            {
                string message = "";
                if (_firstCircles is null || _firstCircles.Count == 0)
                {
                    message.Concat("Невозможно построить ни один круг из точек первого множества.\n");
                }
                if (_secondCircles is null || _secondCircles.Count == 0)
                {
                    message.Concat("Невозможно построить ни один круг из точек второго множества.\n");
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
                            Quadrangle temp = new Quadrangle(new Section(generalTangents[i].first, tempFirstCircle.centre),
                                                             new Section(generalTangents[i].second, tempSecondCircle.centre));
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

        public void Draw(Graphics g, Converter converter)
        {
            g.DrawEllipse(circlePen, new Rectangle(50, 50,
                                                   10, 10));
        }
    }
}
