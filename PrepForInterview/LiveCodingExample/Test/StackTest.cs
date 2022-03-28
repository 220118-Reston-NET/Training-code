using System;
using Collections;
using Xunit;

namespace Test;

public class StackTest
{
    [Fact]
    public void StackShouldPush()
    {
        //Arrange
        Stack<string> stack = new Stack<string>();
        string expectedValue = "Hello";

        //Act
        stack.Push(expectedValue);

        //Assert
        Assert.Equal(expectedValue, stack.Top.Data);
    }

    [Fact]
    public void StackShouldPop()
    {
        //Arrange
        Stack<string> stack = new Stack<string>();
        Node<string> expectedValue = new Node<string>("Hello");
        stack.Top = expectedValue;

        //Act
        string actualValue = stack.Pop();

        //Assert
        Assert.Equal(expectedValue.Data, actualValue);
        Assert.Null(stack.Top);
    }

    [Fact]
    public void EmptyStackShouldFailForPop()
    {
        //Arrange
        Stack<string> stack = new Stack<string>();

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void StackShouldPeek()
    {
        //Arrange
        Stack<string> stack = new Stack<string>();
        Node<string> expectedValue = new Node<string>("Hello");
        stack.Top = expectedValue;

        //Act
        string actualValue = stack.Peek();

        //Assert
        Assert.Equal(expectedValue.Data, actualValue);
    }

    [Fact]
    public void EmptyStackShouldFailForPeek()
    {
        //Arrange
        Stack<string> stack = new Stack<string>();

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }
}