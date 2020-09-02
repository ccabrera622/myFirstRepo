$(document).ready(function()
{
	$('#button1').click(function()
	{
		
		$( "p" ).after( document.createTextNode(compare("rock", getComputerHand())));
		$( "p" ).after( "<br>" );
	})

	$('#button2').click(function()
	{
		$( "p" ).after( document.createTextNode(compare("paper", getComputerHand())));
		$( "p" ).after( "<br>" );
	})


$('#button3').click(function()
	{
		$( "p" ).after( document.createTextNode(compare("scissors", getComputerHand())));
		$( "p" ).after( "<br>" );
	})

});

var hands = ["rock","paper","scissors"];
function getComputerHand()
{
	return hands[parseInt((Math.random()*10)%3)];
}

function compare(p1,p2)
{
	var result = "";
	if(p1 == p2)
	{
		result = "draw";
	}
	else if ((p1 == "rock" && p2 == "scissors")||(p1 == "paper" && p2 == "rock")||(p1 == "scissors" && p2 == "paper"))
	{
		result = "Player 1 wins";
	}
	else if ((p2 == "rock" && p1 == "scissors")||(p2 == "paper" && p1 == "rock")||(p2 == "scissors" && p1 == "paper"))
	{
		result = "Computer wins";
	}

	return ("Player 1 chose " + p1 + " Computer chose " + p2 + " the result is: " + result);
}