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
		result = "player 1 wins";
	}
	else if ((p2 == "rock" && p1 == "scissors")||(p2 == "paper" && p1 == "rock")||(p2 == "scissors" && p1 == "paper"))
	{
		result = "player 2 wins";
	}

	return ("player 1 chose " + p1 + " player 2 chose " + p2 + " the result is: " + result);
}

console.log(compare(getComputerHand(),getComputerHand()));