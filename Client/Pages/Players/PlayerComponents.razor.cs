using Microsoft.AspNetCore.Components;
using Soccer.Shared.FutDb;

namespace Soccer.Client.Pages.Players
{
    public partial class PlayerComponents
    {
        [Parameter]
        public Player Player { get; set; }

        string GetName()
        {
            if (!string.IsNullOrEmpty(Player.CommonName))
                return Player.CommonName;

            return $"{Player.FirstName} {Player.LastName}";
        }
    }
}
