using consolecalculatorapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorhelpertest
{
    public class CalculatortestClass
    {

        [Fact]
        public void Add_Two_Numbers_Together()
        {
            //arrange
            Calculator calculator = new Calculator();

            //act
            int result = calculator.Add(2, 4);

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void SubTract_Two_Numbers_Together()
        {
            //arrange
            Calculator calculator = new Calculator();

            //act
            int result = calculator.Subtract(10, 4);

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiple_Two_Numbers_Together()
        {
            //arrange
            Calculator calculator = new Calculator();

            //act
            int result = calculator.Multiple(10, 4);
            //assert
            Assert.Equal(40, result);

        }

        [Fact]
        public void Divide_Two_Numbers_Together()
        {
            //arrange
            Calculator calculator = new Calculator();

            //act
            double result = calculator.Divide(10, 2);

            //assert
            Assert.Equal((double)5, result);
        }
    }
}
