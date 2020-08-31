var billAmount = 100;
function gratuity(price)
{
	return price*0.2;
}

function totalWithGratuity(money)
{
	return money + gratuity(money);
}

	
console.log(
  `your total, including gratutity is:\
	$${totalWithGratuity(billAmount).toFixed(2)}`
);