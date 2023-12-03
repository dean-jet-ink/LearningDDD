using LeaningDDD.Domain.Entities;
using LeaningDDD.Domain.Repositories;
using LeaningDDD.Domain.ValueObjects;
using Learning_DDD.WinForm.StaticValues;
using LearningDDD.Infrastructure;
using NDDD.WinForm.ViewModels;
using System;

namespace Learning_DDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private MeasureRepository _measureRepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel()
            : this(Factories.CreateMeasure())
        {
                
        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }

        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }
            set
            {
                base.SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText 
        { 
            get 
            {
                return _measureDateText;
            }
            set
            {
                base.SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText 
        {
            get
            {
                return _measureValueText;
            }
            set
            {
                base.SetProperty(ref _measureValueText, value);
            }
        }

        public object Meaures { get; private set; }

        public void Search()
        {
            //var measure = _measureRepository.GetLatest();
            var measure = Measures.GetLatest(new AreaId(10));
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
        }
    }
}
