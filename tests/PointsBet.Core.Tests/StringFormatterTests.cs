using PointsBet_Backend_Online_Code_Test;
      
namespace PointsBet.Core.Tests {
    public class StringFormatterTests
    {
      [Fact]
        public void ToCommaSeparatedList_WithMultipleItems_ReturnsCorrectFormat()
        {
            var items = new[] { "apple", "banana", "cherry" };
            var quote = "\"";
            var expected = "\"apple\", \"banana\", \"cherry\"";

            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToCommaSeparatedList_WithMultipleItemsIncludingNull_ReturnsCorrectFormat()
        {
            var items = new[] { "apple", null, "cherry" };
            var quote = "\"";
            var expected = "\"apple\", \"\", \"cherry\"";

            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToCommaSeparatedList_WithSingleItem_ReturnsSingleQuotedItem()
        {
            var items = new[] { "solo" };
            var quote = "'";
            var expected = "'solo'";

            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToCommaSeparatedList_WithEmptyArray_ReturnsEmptyString()
        {
            var items = Array.Empty<string>();
            var quote = "\"";

            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            Assert.Empty(result);
        }

        [Fact]
        public void ToCommaSeparatedList_WithNullArray_ThrowsArgumentNullException()
        {
            // Arrange
            string[] items = null!;
            var quote = "\"";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => StringFormatter.ToCommaSeparatedList(items, quote));
        }

        [Fact]
        public void ToCommaSeparatedList_WithNullQuote_TreatsAsEmptyString()
        {
            // Arrange
            var items = new[] { "a", "b" };
            string quote = null!;
            var expected = "a, b";

            // Act
            var result = StringFormatter.ToCommaSeparatedList(items, quote);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}