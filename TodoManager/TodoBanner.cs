using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoManager.Helpers;
using System.Globalization;

namespace TodoManager
{
    public partial class TodoBanner : UserControl
    {
        private Point _titleLocation;

        public TodoBanner()
        {
            InitializeComponent();
            _titleLocation = _titleLabel.Location;
        }

        public string Title
        {
            get
            {
                return _titleLabel.Text;
            }
            set
            {
                ParameterValidator.ValidateString(value, false);
                _titleLabel.Text = value;
                AdjustLabels(false);
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                _titleLabel.Text = Properties.Resources.TXT_Banner_Title;
                _dateLabel.Text = _date.ToString("D", CultureInfo.CurrentCulture);
                AdjustLabels(true);
            }
        }

        private void AdjustLabels(bool showDate)
        {
            if (showDate)
            {
                _dateLabel.Visible = true;
                _titleLabel.Location = _titleLocation;
            }
            else
            {
                _dateLabel.Visible = false;
                _titleLabel.Location = new Point(_titleLocation.X, _titleLocation.Y + _dateLabel.Height + 4);
            }
        }
    }
}
