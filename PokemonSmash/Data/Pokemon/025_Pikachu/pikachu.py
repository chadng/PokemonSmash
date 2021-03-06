import Pokemon;
import Move;
import Color;
import Type;

Pikachu = Pokemon.Add("pikachu");
Pikachu.DisplayName = "Pikachu";
Pikachu.Animation = "Pokemon/025_Pikachu/pikachu"
Pikachu.HP = 35;
Pikachu.Attack = 55;
Pikachu.Defense = 30;
Pikachu.SpecialAttack = 50;
Pikachu.SpecialDefense = 40;
Pikachu.Speed = 90;
Pikachu.Color = Color.Yellow;
Pikachu.PrimaryType = Type.Electric;

Pikachu.Width = .5;
Pikachu.Height =  .5;
Pikachu.Weight = 6.0;

Pikachu.CanLearn("growl");
Pikachu.CanLearn("thundershock");
Pikachu.CanLearn("tailwhip");
Pikachu.CanLearn("thunderwave");
Pikachu.CanLearn("quickattack");
Pikachu.CanLearn("electroball");
Pikachu.CanLearn("doubleteam");
Pikachu.CanLearn("slam");
Pikachu.CanLearn("thunderbolt");
Pikachu.CanLearn("feint");
Pikachu.CanLearn("agility");
Pikachu.CanLearn("discharge");
Pikachu.CanLearn("lightscreen");
Pikachu.CanLearn("thunder");

Pikachu.SetMix("walk", "idle", 0.6);
Pikachu.SetMix("walk", "jump", 0.2);

Pikachu.SetMix("jump", "walk", 0.1);
Pikachu.SetMix("jump", "idle", 0.1);

Pikachu.SetMix("idle", "jump", 0.2);
Pikachu.SetMix("idle", "walk", 0.4);

Pikachu.SetMix("idle", "dead", 1);
Pikachu.SetMix("walk", "dead", 1);
Pikachu.SetMix("jump", "dead", 1);