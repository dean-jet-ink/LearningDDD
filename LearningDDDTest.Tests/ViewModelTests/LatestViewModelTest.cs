using LeaningDDD.Domain.Entities;
using LeaningDDD.Domain.Repositories;
using Learning_DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace LearningDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var entity = new MeasureEntity(
                    1,
                    Convert.ToDateTime("2012/12/12 12:34:56"),
                    12.341f
                );

            var measureRepomock = new Mock<IMeasureRepository>();
            measureRepomock.Setup(x => x.GetLatest()).Returns( entity );

            var vm = new LatestViewModel(measureRepomock.Object);
            //エリアID
            //計測日時
            //計測値

            vm.Search();
            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");
        }
    }
}
