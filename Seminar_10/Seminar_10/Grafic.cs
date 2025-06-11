using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_10
{
    class Grafic:Control
    {
        List<int> _valori = new List<int>();
        int _indexSelectat = -1;
        SolidBrush _brushGrafic = (SolidBrush)Brushes.White;
        public Grafic()
        {
            SetStyle(ControlStyles.ResizeRedraw|ControlStyles.AllPaintingInWmPaint
                |ControlStyles.OptimizedDoubleBuffer, true);
            Paint += Grafic_Paint;
            MouseMove += Grafic_MouseMove;
            Click+=(s,e)=>IndexSelectatChanged?.Invoke(this, _indexSelectat);
        }

        public EventHandler<int> IndexSelectatChanged;

       

        public Color CuloareGrafic
        {
            get { return _brushGrafic.Color; }
            set
            {
                if (value != _brushGrafic.Color)
                {
                    _brushGrafic = new SolidBrush(value);
                    Invalidate();
                }
            }
        }
        public void SetValori(List<int> valori)
        {
            _valori.Clear();
            _valori.AddRange(valori);
            Invalidate();
        }
        private void Grafic_MouseMove(object? sender, MouseEventArgs e)
        {
            var n = _valori.Count;
            var index = -1;
            if (n > 0)
            {
                var w = Width / n;
                index = e.X / w;
            }


            if (index != _indexSelectat)
            {
                _indexSelectat = index;
                Invalidate();
            }
        }
        private void Grafic_Paint(object? sender,PaintEventArgs e)
        {
            var g = e.Graphics;
            g.FillRectangle(_brushGrafic, 0, 0, Width, Height);

            var n = _valori.Count;
            if (n == 0) return;
            var w = Width / n;
            var h = Height / _valori.Max();
            for(int i = 0; i < _valori.Count; i++)
            {
                Rectangle ri=new Rectangle(
                i * w,
                Height - _valori[i] * h, w, _valori[i] * h);
                var brush = i == _indexSelectat ? Brushes.Red : Brushes.LawnGreen;

                g.FillRectangle(brush, ri);
                g.DrawRectangle(Pens.Black, ri);
            }
        }
        
    }
}
