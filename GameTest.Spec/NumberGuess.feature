Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
@game_result_highLow
Scenario: Lose Game
	Given I have a target card "4"
	And I guess "7"
	When I launch the game
	Then the result will be Lose
@game_result_highLow
Scenario: Win Game
	Given I have a target card "4"
	And I guess "4"
	When I launch the game
	Then the result will be Win
@game_result_highLow
Scenario: Win Game After 4 Incorrect Guesses
	Given I have a target card "4"
	And I guess multiple "3", then "5", then "Queen", then "Ace" then "4"
	When I launch the game
	Then the result will be Win
@game_result_highLow
Scenario: Lose Game After 5 Incorrect Guesses
	Given I have a target card "4"
	And I guess multiple "3", then "5", then "Queen", then "Ace" then "6"
	When I launch the game
	Then the result will be Lose