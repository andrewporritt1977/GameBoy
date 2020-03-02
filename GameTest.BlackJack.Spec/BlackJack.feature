Feature: BlackJack
	In order to play the game mistakes
	As a terrible blackjack player
	I want to be able to play blackjack
@game_end
Scenario: Player BlackJack
Given the top cards are "5", "3", "Ace", "10", "5", "8", "9", "2", "1", "4"
When the player does not take a card
And the game is launched.
Then the result is Player BlackJack
@game_end
Scenario: Player Bust
Given the top cards are "5", "3", "9", "10", "5", "8", "9", "2", "1", "4"
When when the player takes a card
And the game is launched.
Then the result is Player Bust
@game_end
Scenario: Dealer BlackJack
Given the top cards are "King", "Ace", "9", "10", "5", "8", "9", "2", "1", "4"
When the player does not take a card
And the game is launched.
Then the result is Dealer BlackJack
@game_end
Scenario: Dealer Bust
Given the top cards are "King", "6", "9", "10", "10", "8", "9", "2", "1", "4"
When the player does not take a card
And the game is launched.
Then the result is Dealer Bust
@game_end
Scenario: Dealer Win
Given the top cards are "King", "8", "7", "10", "5", "8", "9", "2", "1", "4"
When the player does not take a card
And the game is launched.
Then the result is Dealer Win
@game_end
Scenario: Dealer Loss
Given the top cards are "King", "8", "4", "10", "5", "8", "9", "2", "1", "4"
When when the player takes a card and then does not take a card.
And the game is launched.
Then the result is Dealer Loss