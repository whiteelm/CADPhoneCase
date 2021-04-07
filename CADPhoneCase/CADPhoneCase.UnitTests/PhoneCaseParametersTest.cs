using System;
using NUnit.Framework;

namespace CADPhoneCase.UnitTests
{
    [TestFixture]
    public class PhoneCaseParametersTest
    {
        
        [Test]
        public void CaseLength_GoodCaseLength_ReturnsSameCaseLength()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCaseLength = 200;
            const double expectedCaseLength = sourceCaseLength;

            //Act
            parameters.CaseLength = sourceCaseLength;
            var actualCaseLength = parameters.CaseLength;

            //Assert
            Assert.AreEqual(expectedCaseLength, actualCaseLength);
        }

        [Test]
        public void CaseLength_WrongCaseLength_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCaseLength = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CaseLength = wrongCaseLength;
                }
            );
        }

        [Test]
        public void CaseWidth_GoodCaseWidth_ReturnsSameCaseWidth()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCaseWidth = 200;
            const double expectedCaseWidth = sourceCaseWidth;

            //Act
            parameters.CaseWidth = sourceCaseWidth;
            var actualCaseWidth = parameters.CaseWidth;

            //Assert
            Assert.AreEqual(expectedCaseWidth, actualCaseWidth);
        }

        [Test]
        public void CaseWidth_WrongCaseWidth_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCaseWidth = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CaseWidth = wrongCaseWidth;
                }
            );
        }

        [Test]
        public void CaseHeight_GoodCaseHeight_ReturnsSameCaseHeight()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCaseHeight = 15;
            const double expectedCaseHeight = sourceCaseHeight;

            //Act
            parameters.CaseHeight = sourceCaseHeight;
            var actualCaseHeight = parameters.CaseHeight;

            //Assert
            Assert.AreEqual(expectedCaseHeight, actualCaseHeight);
        }

        [Test]
        public void CaseHeight_WrongCaseHeight_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCaseHeight = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CaseHeight = wrongCaseHeight;
                }
            );
        }

        [Test]
        public void CameraHoleLength_GoodCameraHoleLength_ReturnsSameCameraHoleLength()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCameraHoleLength = 50;
            const double expectedCameraHoleLength = sourceCameraHoleLength;

            //Act
            parameters.CameraHoleLength = sourceCameraHoleLength;
            var actualCameraHoleLength = parameters.CameraHoleLength;

            //Assert
            Assert.AreEqual(expectedCameraHoleLength, actualCameraHoleLength);
        }

        [Test]
        public void CameraHoleLength_WrongCameraHoleLength_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCameraHoleLength = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CameraHoleLength = wrongCameraHoleLength;
                }
            );
        }

        [Test]
        public void CameraHoleWidth_GoodCameraHoleWidth_ReturnsSameCameraHoleWidth()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCameraHoleWidth = 50;
            const double expectedCameraHoleWidth = sourceCameraHoleWidth;

            //Act
            parameters.CameraHoleWidth = sourceCameraHoleWidth;
            var actualCameraHoleWidth = parameters.CameraHoleWidth;

            //Assert
            Assert.AreEqual(expectedCameraHoleWidth, actualCameraHoleWidth);
        }

        [Test]
        public void CameraHoleWidth_WrongCameraHoleWidth_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCameraHoleWidth = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CameraHoleWidth = wrongCameraHoleWidth;
                }
            );
        }

        [Test]
        public void CameraTopGap_GoodCameraTopGap_ReturnsSameCameraTopGap()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCameraTopGap = 20;
            const double expectedCameraTopGap = sourceCameraTopGap;

            //Act
            parameters.CameraTopGap = sourceCameraTopGap;
            var actualCameraTopGap = parameters.CameraTopGap;

            //Assert
            Assert.AreEqual(expectedCameraTopGap, actualCameraTopGap);
        }

        [Test]
        public void CameraTopGap_WrongCameraTopGap_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCameraTopGap = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CameraTopGap = wrongCameraTopGap;
                }
            );
        }

        [Test]
        public void CameraRightGap_GoodCameraRightGap_ReturnsSameCameraRightGap()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceCameraRightGap = 20;
            const double expectedCameraRightGap = sourceCameraRightGap;

            //Act
            parameters.CameraRightGap = sourceCameraRightGap;
            var actualCameraRightGap = parameters.CameraRightGap;

            //Assert
            Assert.AreEqual(expectedCameraRightGap, actualCameraRightGap);
        }

        [Test]
        public void CameraRightGap_WrongCameraRightGap_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongCameraRightGap = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.CameraRightGap = wrongCameraRightGap;
                }
            );
        }

        [Test]
        public void ChargerHoleHeight_GoodChargerHoleHeight_ReturnsSameChargerHoleHeight()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceChargerHoleHeight = 6;
            const double expectedChargerHoleHeight = sourceChargerHoleHeight;

            //Act
            parameters.ChargerHoleHeight = sourceChargerHoleHeight;
            var actualChargerHoleHeight = parameters.ChargerHoleHeight;

            //Assert
            Assert.AreEqual(expectedChargerHoleHeight, actualChargerHoleHeight);
        }

        [Test]
        public void ChargerHoleHeight_WrongChargerHoleHeight_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongChargerHoleHeight = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.ChargerHoleHeight = wrongChargerHoleHeight;
                }
            );
        }

        [Test]
        public void ChargerHoleWidth_GoodChargerHoleWidth_ReturnsSameChargerHoleWidth()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceChargerHoleWidth = 15;
            const double expectedChargerHoleWidth = sourceChargerHoleWidth;

            //Act
            parameters.ChargerHoleWidth = sourceChargerHoleWidth;
            var actualChargerHoleWidth = parameters.ChargerHoleWidth;

            //Assert
            Assert.AreEqual(expectedChargerHoleWidth, actualChargerHoleWidth);
        }

        [Test]
        public void ChargerHoleWidth_WrongChargerHoleWidth_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongChargerHoleWidth = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.ChargerHoleWidth = wrongChargerHoleWidth;
                }
            );
        }

        [Test]
        public void MiniJackDiameter_GoodMiniJackDiameter_ReturnsSameMiniJackDiameter()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceMiniJackDiameter = 3.5;
            const double expectedMiniJackDiameter = sourceMiniJackDiameter;

            //Act
            parameters.MiniJackDiameter = sourceMiniJackDiameter;
            var actualMiniJackDiameter = parameters.MiniJackDiameter;

            //Assert
            Assert.AreEqual(expectedMiniJackDiameter, actualMiniJackDiameter);
        }

        [Test]
        public void MiniJackDiameter_WrongMiniJackDiameter_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double wrongMiniJackDiameter = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.MiniJackDiameter = wrongMiniJackDiameter;
                }
            );
        }

        [Test]
        public void MiniJackGap_GoodMiniJackGap_ReturnsSameMiniJackGap()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseWidth = 100,
                MiniJackDiameter = 3.5,
                ChargerHoleWidth = 15
            };
            const double sourceMiniJackGap = 20;
            const double expectedMiniJackGap = sourceMiniJackGap;

            //Act
            parameters.MiniJackGap = sourceMiniJackGap;
            var actualMiniJackGap = parameters.MiniJackGap;

            //Assert
            Assert.AreEqual(expectedMiniJackGap, actualMiniJackGap);
        }

        [Test]
        public void MiniJackGap_WrongMiniJackGap_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseWidth = 100,
                MiniJackDiameter = 3.5,
                ChargerHoleWidth = 15
            };
            const double wrongMiniJackGap = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.MiniJackGap = wrongMiniJackGap;
                }
            );
        }

        [Test]
        public void SideButtonsHoleHeight_GoodSideButtonsHoleHeight_ReturnsSameSideButtonsHoleHeight()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseHeight = 15
            };
            const double sourceSideButtonsHoleHeight = 3;
            const double expectedSideButtonsHoleHeight = sourceSideButtonsHoleHeight;

            //Act
            parameters.SideButtonsHoleHeight = sourceSideButtonsHoleHeight;
            var actualSideButtonsHoleHeight = parameters.SideButtonsHoleHeight;

            //Assert
            Assert.AreEqual(expectedSideButtonsHoleHeight, actualSideButtonsHoleHeight);
        }

        [Test]
        public void SideButtonsHoleHeight_WrongSideButtonsHoleHeight_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseHeight = 15
            };
            const double wrongSideButtonsHoleHeight = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.SideButtonsHoleHeight = wrongSideButtonsHoleHeight;
                }
            );
        }
        
        [Test]
        public void SideButtonsHoleWidth_GoodSideButtonsHoleWidth_ReturnsSameSideButtonsHoleWidth()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseLength = 200,
                SideButtonsGap = 20
            };
            const double sourceSideButtonsHoleWidth = 5;
            const double expectedSideButtonsHoleWidth = sourceSideButtonsHoleWidth;

            //Act
            parameters.SideButtonsHoleWidth = sourceSideButtonsHoleWidth;
            var actualSideButtonsHoleWidth = parameters.SideButtonsHoleWidth;

            //Assert
            Assert.AreEqual(expectedSideButtonsHoleWidth, actualSideButtonsHoleWidth);
        }

        [Test]
        public void SideButtonsHoleWidth_WrongSideButtonsHoleWidth_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseLength = 200,
                SideButtonsGap = 20
            };
            const double wrongSideButtonsHoleWidth = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.SideButtonsHoleWidth = wrongSideButtonsHoleWidth;
                }
            );
        }

        [Test]
        public void SideButtonsGap_GoodSideButtonsGap_ReturnsSameSideButtonsGap()
        {
            //Setup
            var parameters = new PhoneCaseParameters();
            const double sourceSideButtonsGap = 20;
            const double expectedSideButtonsGap = sourceSideButtonsGap;

            //Act
            parameters.SideButtonsGap = sourceSideButtonsGap;
            var actualSideButtonsGap = parameters.SideButtonsGap;

            //Assert
            Assert.AreEqual(expectedSideButtonsGap, actualSideButtonsGap);
        }

        [Test]
        public void SideButtonsGap_WrongSideButtonsGap_ThrowsException()
        {
            //Setup
            var parameters = new PhoneCaseParameters
            {
                CaseLength = 200,
                SideButtonsGap = 20
            };
            const double wrongSideButtonsGap = 0;
            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameters.SideButtonsGap = wrongSideButtonsGap;
                }
            );
        }
    }
}
