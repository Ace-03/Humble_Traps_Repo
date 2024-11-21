using NUnit.Framework;
using NSubstitute;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTest
{
    [Test]
    public void PlayerEntering_PlayerTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        characterMover.IsPlayer.Returns(true);

        trap.HandleCharacterEntered(characterMover, TrapTargetType.Player);
        
        Assert.AreEqual(-1, characterMover.Health);
    }

    [Test]
    public void NPCEntering_NPCTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover, TrapTargetType.NPC);
        Assert.AreEqual(-1, characterMover.Health);
    }
}


