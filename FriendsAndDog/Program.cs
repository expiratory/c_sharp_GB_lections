int count = 0;
int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
bool friend = true;

while(distance > 10)
{
    if(friend = false)
    {
        int time = distance/(first_friend_speed + dog_speed);
        friend = true;
        distance = distance - (first_friend_speed + second_friend_speed)*time;
        count = count + 1;
    }
    if(friend = true)
    {
        int time = distance/(second_friend_speed + dog_speed);
        friend = false;
        distance = distance - (first_friend_speed + second_friend_speed)*time;
        count = count + 1;
    }
}

    Console.Write("Собака пробежит ");
    Console.Write(count);
    Console.WriteLine(" раз");
