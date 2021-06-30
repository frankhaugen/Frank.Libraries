using System;
using System.Collections.Generic;
using System.Linq;
using Frank.Libraries.Gaming.Starfinder.Common;
using Frank.Libraries.Gaming.Starfinder.Models;
using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder
{
    public class StarshipController
    {
        private readonly Starship _ship;
        private Dictionary<Arc, int> _shields;
        private Dictionary<Arc, Dictionary<int, Mount>> _mounts;
        private int _hullPoints;

        public StarshipController(Starship ship)
        {
            _ship = ship;
            _shields = new Dictionary<Arc, int> { { Arc.Forward, _ship.ShieldGenerator.ShieldPoints }, { Arc.Starboard, _ship.ShieldGenerator.ShieldPoints }, { Arc.Aft, _ship.ShieldGenerator.ShieldPoints }, { Arc.Port, _ship.ShieldGenerator.ShieldPoints } };
            _hullPoints = _ship.HitPoints;
            _mounts = ship.Mounts.ToDictionary(x => x.Arc, y => new Dictionary<int, Mount>() { { 0, y } });
        }

        public int PilotingCheck()
        {
            var rollResult = DiceRoller.RollDice((1, Dice.Icasahedron));
            var piloting = _ship.Pilot.Character.Skills.SingleOrDefault(x => x.Name == SkillName.Piloting);
            return rollResult + piloting?.Rank ?? 0;
        }

        public int Attack(CrewMember gunner, Arc arc, RollResult rollResult)
        {
            if (!_mounts.ContainsKey(arc)) throw new ArgumentException("Attacks must be done with an arc that have mounts", nameof(arc));
            if (gunner.Role != Role.Gunner) throw new ArgumentException("Attacks can only be made by a gunner", nameof(gunner));
            var piloting = gunner.Character.Skills.SingleOrDefault(x => x.Name == SkillName.Piloting);
            return rollResult.Result + piloting?.Rank ?? 0;
        }
    }
}