using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AssertionExamples {

  [TestMethod]
  public void return_based_assertion() {

    string message = GreetingBuilder.Build();

    Assert.AreEqual("Hello, World", message);
  }

  [TestMethod]
  public void state_based_assertion() {

    GreetingBuilder gb = new GreetingBuilder();

    gb.Build();

    Assert.AreEqual("Hello, World", g.Message);
  }

  [TestMethod]
  public void interaction_based_assertion() {

    IEmailService emailService =
        Substitute.For<IEmailService>();

    Message expectedMessage =
	new Message( "joe@email.com", "Hello, World" )

    GreetingSender gs = new GreetingSender( emailService );

    gs.SendTo( "joe@email.com" );

    emailService.Received().Send( Arg.Is( expectedMessage ) );
  }

}
