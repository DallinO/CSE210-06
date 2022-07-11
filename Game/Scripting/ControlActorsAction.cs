using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService, Player player)
        {
            this.keyboardService = keyboardService;
            this.direction = player.GetPosition();
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Bullet bullet = (Bullet)cast.GetFirstActor("Bullet");

            // left
            if (keyboardService.IsKeyDown("left"))
            {
                direction = new Point(direction.GetX() - Constants.CELL_SIZE, direction.GetY());
            }

            // right
            if (keyboardService.IsKeyDown("right"))
            {
                direction = new Point(direction.GetX() + Constants.CELL_SIZE, direction.GetY());
            }

            Player player = (Player)cast.GetFirstActor("Player");
            player.SetPosition(direction);

            if (keyboardService.IsKeyDown("space"))
            {
                bullet.AddBullet(player);
            }

        }
    }
}