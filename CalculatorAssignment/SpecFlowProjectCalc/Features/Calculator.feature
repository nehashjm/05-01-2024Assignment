Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectCalc/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Multiply two numbers
	Given the first number is 20
	And the second number is 20
	When the two numbers are Multiplied
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are Substracted
	Then the result should be 20

Scenario: Division two numbers
	Given the first number is 20
	And the second number is 5
	When the two numbers are Divided
	Then the result should be 4