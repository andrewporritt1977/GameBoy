Feature: NumberPoke
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	@game_results
Scenario: Player has a Pair
	Given the top cards are "1", "3", "3", "Ace", "Queen", "6"
	And I hold cards "2,3"
	When I launch the game
	Then the result will be "Win"
	@game_results
Scenario: Player has three of a kind
	Given the top cards are "1", "3", "3", "3", "Queen", "6"
	And I hold cards "2,3"
	When I launch the game
	Then the result will be "Super-Win"
	@game_results
Scenario: Player has no Pair
	Given the top cards are "1", "3", "3", "Ace", "Queen", "6"
	And I hold cards "1,2,3"
	When I launch the game
	Then the result will be "Win"
	@game_results
Scenario: I wish to hold 2 cards and re-deal the other earning a superwin
	Given the top cards are "1", "3", "3", "Ace", "Queen", "6"
	And I hold cards "1"
	When I launch the game
	Then the result will be "Lose"
	@game_results
Scenario: I wish to re-deal all cards when I have a pair
	Given the top cards are "1", "3", "3", "Ace", "Queen", "6"
	And I hold cards "3"
	When I launch the game
	Then the result will be "Lose"
