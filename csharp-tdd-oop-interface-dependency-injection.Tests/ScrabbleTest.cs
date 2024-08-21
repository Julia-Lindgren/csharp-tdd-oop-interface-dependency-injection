using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            IAlphabet english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            IAlphabet russian = new Russian();
            Scrabble scrabble = new Scrabble(russian);
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            IAlphabet greek = new Greek();
            Scrabble scrabble = new Scrabble(greek);
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}