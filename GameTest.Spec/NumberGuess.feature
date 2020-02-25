Feature: NumberGuess
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
@game_result_numberGuess
Scenario: Failed Game
	Given I have a target number 4
	And I guess 7
	Then the game result will be Lose
@game_result_numberGuess
Scenario: Successful Game
	Given I have a target number 4
	And I guess 4
	Then the game result will be Win
