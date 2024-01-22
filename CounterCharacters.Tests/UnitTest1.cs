namespace CountCharacters.Tests
{
    public class CharacterCounterTests
    {
        public static IEnumerable<object[]> CorrectCountedLetters = new List<object[]>
        {
            new object[]
            {
                "John243434",
                new Dictionary<char,int>
                {
                    ['j'] = 1,
                    ['o'] = 1,
                    ['h'] = 1,
                    ['n'] = 1
                }
            },
            new object[]
            {
                "David41_!#",
                new Dictionary<char,int>
                {
                    ['d'] = 2,
                    ['a'] = 1,
                    ['v'] = 1,
                    ['i'] = 1
                }
            },
            new object[]
            {
                "Mason marjelo443@",
                new Dictionary<char,int>
                {
                    ['m'] = 2,
                    ['a'] = 2,
                    ['o'] = 2,
                    ['s'] = 1,
                    ['n'] = 1,
                    ['r'] = 1,
                    ['j'] = 1,
                    ['e'] = 1,
                    ['l'] = 1,
                }
            },
        };

        [Theory(DisplayName = "Should correctly count letters in string")]
        [MemberData(nameof(CorrectCountedLetters))]
        [MemberData(nameof(CorrectCountedLetters))]
        public void PositiveTests(string input, Dictionary<char, int> expectedResult)
        {
            var counter = new CharacterCounter(input);
            var countedList = counter.StringCounter();
            Assert.Equal(expectedResult, countedList);
        }
    }
}