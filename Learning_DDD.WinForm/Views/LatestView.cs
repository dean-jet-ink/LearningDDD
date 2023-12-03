﻿using Learning_DDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace Learning_DDD.WinForm.Views
{
    public partial class LatestView : BaseForm
    {
        private LatestViewModel _viewModel = new LatestViewModel();

        public LatestView()
        {
            InitializeComponent();

            AreaIdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AreaIdText));
            MeasureDateTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MeasureDateText));
            MeasureValueTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MeasureValueText));
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                _viewModel.Search();
            } catch(Exception ex)
            {
                ExceptionProc(ex);
            }
        }
    }
}
