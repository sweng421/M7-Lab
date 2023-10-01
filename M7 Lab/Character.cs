namespace M7_Lab
{
    public class Character: NovelElement
    {
        private char character;

        public Character (char character)
        {
            this.character = character;
        }

        public char GetCharacter()
        {
            return character;
        }
        public void SetCharacter(char character) 
        {
            this.character = character;
        }
    }
}
