using Frank.Libraries.Gaming.Starfinder.Extensions;
using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;
using Frank.Libraries.Gaming.Starfinder.Space;
using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder;

public class StarshipSheet
{
    private readonly Starship _ship;
    private int _hullPoints;
    private readonly Dictionary<Arc, Dictionary<int, Mount>> _mounts;
    private Dictionary<Arc, int> _shields;

    public StarshipSheet(Starship ship)
    {
        _ship = ship;
        _shields = new Dictionary<Arc, int> { { Arc.Forward, _ship.ShieldGenerator.ShieldPoints }, { Arc.Starboard, _ship.ShieldGenerator.ShieldPoints }, { Arc.Aft, _ship.ShieldGenerator.ShieldPoints }, { Arc.Port, _ship.ShieldGenerator.ShieldPoints } };
        _hullPoints = _ship.HitPoints;
        _mounts = ship.Mounts.ToDictionary(x => x.Arc, y => new Dictionary<int, Mount> { { 0, y } });
    }

    public int PilotingCheck()
    {
        var rollResult = Dice.D20.Roll();
        // var piloting = _ship.Pilot.Character.Skills.SingleOrDefault(x => x.Name == SkillName.Piloting);
        return rollResult;
    }

    public int Attack(CrewMember gunner, Arc arc, int rollResult)
    {
        if (!_mounts.ContainsKey(arc))
        {
            throw new ArgumentException("Attacks must be done with an arc that have mounts", nameof(arc));
        }

        if (gunner.Role != Role.Gunner)
        {
            throw new ArgumentException("Attacks can only be made by a gunner", nameof(gunner));
        }

        var piloting = 1; // gunner.Character.Skills.SingleOrDefault(x => x.Name == SkillName.Piloting);
        return piloting;
    }
}