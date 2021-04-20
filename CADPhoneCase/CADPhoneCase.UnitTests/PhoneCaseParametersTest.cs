using System;
using NUnit.Framework;

namespace CADPhoneCase.UnitTests
{
    [TestFixture]
    public class PhoneCaseParametersTest
    {
        [TestCase(ParameterName.MiniJackGap, 0,
            TestName = "Негативный тест проверки MiniJackGap в индексаторе")]
        [TestCase(ParameterName.SideButtonsHoleWidth, 0,
            TestName = "Негативный тест проверки SideButtonsHoleWidth в " +
                       "индексаторе")]
        [TestCase(ParameterName.SideButtonsHoleHeight, 0,
            TestName = "Негативный тест проверки SideButtonsHoleHeight в " +
                       "индексаторе")]
        public void Indexer_BadValue_ThrowsException(ParameterName name, 
            double wrongValue)
        {
            //Setup
            var phoneCaseParameters = new PhoneCaseParameters();

            //Asset
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    phoneCaseParameters[name] = wrongValue;
                });
        }


        [TestCase(ParameterName.MiniJackGap, 10,
            TestName = "Позитивный тест проверки MiniJackGap в индексаторе")]
        [TestCase(ParameterName.SideButtonsHoleWidth, 10,
            TestName = "Позитивный тест проверки SideButtonsHoleWidth в " +
                       "индексаторе")]
        [TestCase(ParameterName.SideButtonsHoleHeight, 5,
            TestName = "Позитивный тест проверки SideButtonsHoleHeight в " +
                       "индексаторе")]
        [TestCase(ParameterName.CaseHeight, 10,
            TestName = "Негативный тест проверки SideButtonsHoleHeight в " +
                       "индексаторе")]
        public void Indexer_CorrectValue_ReturnsSameValue
            (ParameterName name, double correctValue)
        {
            //Setup
            var phoneCaseParameters = new PhoneCaseParameters();
            var expectedValue = correctValue;

            //Act
            phoneCaseParameters[name] = correctValue;
            var actualValue = phoneCaseParameters[name];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
