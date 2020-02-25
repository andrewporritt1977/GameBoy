Feature: NumberGuess
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@game_result_numberGuess
Scenario: Failed Game
	Given I guess the incorrect card
	When I have started the game
	Then the game result will be Lose

@game_result_numberGuess
Scenario: Successful Game
	Given I guess the correct card
	When I have started the game
	Then the game result will be Win

