function isPrime(num)
{
	if(num%2 == 0)
	{
		return false;
	}

	for(let i = 3; i<num; i+=2)
	{
		if(num%i == 0)
		{
			return false
		}
	}

	return true;
}