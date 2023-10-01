using M7_Lab.CompositeNovelElements;

namespace M7_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Page IntroPage = new Page();
            Column introColumn = new Column();
            IntroPage.Save(introColumn);
            introColumn.Edit();
            Novel JohnWick = new Novel(IntroPage);
            LineOfText introParagraph = new LineOfText();
            introColumn.Save(introParagraph);
            JohnWick.Save(IntroPage);
            JohnWick.View(IntroPage);

            introParagraph.Edit();

            Image introImage = new Image("Photo from last week of September");
            Frame introFrame = new Frame();
            introFrame.Save(introImage);
            introColumn.Save(introFrame);
            JohnWick.View(IntroPage);

            Archive novels = new Archive();
            novels.Add(JohnWick);
            novels.View();

        }
    }
}
