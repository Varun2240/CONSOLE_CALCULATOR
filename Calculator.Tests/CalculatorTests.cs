namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]

    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }


    
        [Fact]
        public void Test_AddingSmallPositiveNumbers_ReturnsExpectedSum()
        {
            // Arrange
            float leftOperand = 0.1f;
            float rightOperand = 0.2f;

            // Act
            float result = Calculator.Add.Eval(leftOperand, rightOperand);

            // Assert
            Assert.Equal(0.3f, result);
        }

        [Fact]

        public void Test_AddingExtremeValues_ReturnsExpectedSum()
        {
            // Arrange
            float leftOperand = float.MaxValue;
            float rightOperand = float.MinValue;

            // Act
            float result = Calculator.Add.Eval(leftOperand, rightOperand);

            // Assert
            Assert.Equal(0f, result);
        }

        [Fact]


        public void TestAddOperation()
        {
            Assert.Equal(8, Evaluator.Eval("+", 6, 2));
        }
        [Fact]
        public void TestMultiplyOperation()
        {
            Assert.Equal(12, Evaluator.Eval("*", 6, 2));
        }
        public void Test_AddingNumberAndZero_ReturnsSameNumber()
        {
            // Arrange
            float leftOperand = 12345.67f;
            float zeroOperand = 0f;

            // Act
            float result = Calculator.Add.Eval(leftOperand, zeroOperand);

            // Assert
            Assert.Equal(leftOperand, result);
        }
    [Fact]
    public void Eval_MultiplyingPositiveNumbers_ReturnsCorrectValue()
    {
        // Arrange
        float lhs = 5.5f;
        float rhs = 4.5f;

        // Act
        float result = Calculator.Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(24.75f, result);
    }

    [Fact]
    public void Eval_MultiplyingPositiveAndNegativeNumber_ReturnsCorrectValue()
    {
        // Arrange
        float lhs = 10f;
        float rhs = -3.5f;

        // Act
        float result = Calculator.Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(-35f, result);
    }

    [Fact]
    public void Eval_MultiplyingTwoNegativeNumbers_ReturnsCorrectValue()
    {
        // Arrange
        float lhs = -2.5f;
        float rhs = -7.5f;

        // Act
        float result = Calculator.Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(18.75f, result);
    }

    [Fact]
    public void Eval_MultipliesTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 4.0f;
        float rhs = 6.0f;

        // Act
        float result = Calculator.Evaluator.Eval("*", lhs, rhs);

        // Assert
        Assert.Equal(24.0f, result);
    }

    [Fact]
    public void Eval_ThrowsExceptionForUnimplementedOperator()
    {
        // Arrange
        float lhs = 5.0f;
        float rhs = 3.0f;

        // Act and Assert
        Assert.Throws<System.Exception>(() => Calculator.Evaluator.Eval("^", lhs, rhs));
    }

    [Fact]
    public void Eval_DividingPositiveNumbers_ReturnsCorrectValue()
    {
        // Arrange
        float lhs = 10f;
        float rhs = 2.5f;

        // Act
        float result = Calculator.Divide.Eval(lhs, rhs);

        // Assert
        Assert.Equal(4f, result);
    }

    [Fact]
    public void Eval_DividingPositiveByNegativeNumber_ReturnsNegativeValue()
    {
        // Arrange
        float lhs = 10f;
        float rhs = -2.5f;

        // Act
        float result = Calculator.Divide.Eval(lhs, rhs);

        // Assert
        Assert.Equal(-4f, result);
    }

    [Fact]
    public void Eval_DividingByInfiniteValue_ReturnsZero()
    {
        // Arrange
        float lhs = 10f;
        float rhs = float.PositiveInfinity;

        // Act
        float result = Calculator.Divide.Eval(lhs, rhs);

        // Assert
        Assert.Equal(0f, result);
    }
    public void Eval_HandlesNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = -5.0f;
        float rhs = 3.0f;

        // Act
        float addResult = Calculator.Evaluator.Eval("+", lhs, rhs);
        float multiplyResult = Calculator.Evaluator.Eval("*", lhs, rhs);
        float divideResult = Calculator.Evaluator.Eval("/", lhs, rhs);

        // Assert
        Assert.Equal(-2.0f, addResult);
        Assert.Equal(-15.0f, multiplyResult);
        Assert.Equal(-1.6666666f, divideResult);
    }

}
    


