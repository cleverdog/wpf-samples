﻿using Infragistics.Samples.Framework;
using Infragistics.Samples.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IGDataPieChart.WPF.Samples.Display
{
    public partial class Overview : SampleContainer
    {
        public FinancialDataCollection Data { get; set; }
        public Overview()
        {
            InitializeComponent();
            this.Data = new FinancialDataCollection();
            this.DataContext = this;
        }
    }
}