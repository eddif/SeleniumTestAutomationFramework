namespace WIWDemoFramework
{
    public class TestimonialsPage
    {
        public void Goto()
        {
            Pages.TopNavigation.Testimonials();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Testimonials");
        }
    }
}