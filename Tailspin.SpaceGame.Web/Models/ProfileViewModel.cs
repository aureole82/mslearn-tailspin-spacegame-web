namespace TailSpin.SpaceGame.Web.Models
{
    public class ProfileViewModel
    {
        /// <summary> The player profile. </summary>
        public Profile Profile { get; set; }

        /// <summary> The player's rank according to the active filter. </summary>
        public string Rank { get; set; }
    }
}