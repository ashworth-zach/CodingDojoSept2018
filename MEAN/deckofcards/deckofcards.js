class Card {
    constructor(stringval, suitType, value) {
        this.strVal = stringval;
        this.suit = suitType;
        this.val = value;
    }

}
class Deck {
    constructor() {
        this.cards = [];
        this.suits = ["hearts", "diamonds", "spades", "clubs"];
        this.values = ["Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King"];
    }
    printdeck() {
        for (var i = 0; i < this.cards.length; i++) {
            console.log(this.cards[i].strVal + " of " + this.cards[i].suit);
        }
        return this;
    }
    reset() {
        this.cards = [];
        for (var i = 0; i < this.suits.length; i++) {
            for (var j = 0; j < this.values.length; j++) {
                var card = new Card(this.values[j], this.suits[i], j);
                this.cards.push(card);
            }
        }
        return this;
    }
    shuffle() {
        for (var i = 0; i < cards.length; i++) {
            var j = Math.floor(Math.random() * Math.floor(i)); // 0 <= j <= i-1
            console.log(cards[j] + "print statement");
            var tmp = cards[j];
            cards[j] = cards[i - 1];
            cards[i - 1] = tmp;
        }

        return this;
    }
    Deal()
    {
        if(this.cards.length != 0)
        {
            var tempCard = this.cards[this.cards.length-1];
            this.cards.pop();
            return tempCard;
        }
        else
        {
            return null;
        }
    }
}
class Player{
    constructor(name){
        this.name=name;
        this.hand=[];
    }
    Draw(deck)
    {
        this.hand.push(deck.Deal());
        return this.hand;
    }
    Discard()
    {
        if(this.hand.length != 0)
        {
            var tempCard = this.hand[this.hand.length-1];
            this.hand.pop();
            return tempCard;
        }
        else
        {
            return null;   
        }
    }
}
var deck = new Deck();

var x = new Player("zach");