using Xunit;

public class CardTests{
    [Fact]
    public void CanCreateCardWithValue(){
        var card = new Card(CardValue.Ace, CardSuit.Clubs);
        Assert.NotNull(card.Suit);
        Assert.NotNull(card.Value);
        Assert.Equal(CardSuit.Clubs, card.Suit);
        Assert.Equal(CardValue.Ace, card.Value);
    }
}