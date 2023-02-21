﻿using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        public WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.Weathers.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            List<Weather> _Find = _weather.Weathers.Where(x => x.CityName.ToLower().Contains(textBox1.Text.ToLower()) ).ToList();
            WeatherDataGrid.DataSource = _Find;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            
        } 
    }
    
}