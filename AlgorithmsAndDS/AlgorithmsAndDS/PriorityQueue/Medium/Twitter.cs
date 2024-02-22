namespace AlgorithmsAndDS.PriorityQueue.Medium;

// 355. Design Twitter
public class Twitter
{
    private static int TimeStamp = 0;
    private Dictionary<int, User> UserMap = new();

    public class Tweet
    {
		public int Id;
		public int Time;
		public Tweet Next;

		public Tweet(int id)
        {
			Id = id;
			Time = TimeStamp++;
		}
	}

    public class User
    {
		public int Id;
		public HashSet<int> Followed;
		public Tweet TweetHead;

		public User(int id)
        {
			Id = id;
			Followed = new HashSet<int>();
			Follow(id); // follow itself
		}

		public void Follow(int id){
			Followed.Add(id);
		}

		public void Unfollow(int id){
			Followed.Remove(id);
		}


		// everytime user post a new tweet, add it to the head of tweet list.
		public void Post(int id)
        {
			Tweet t = new Tweet(id);
			t.Next = TweetHead;
			TweetHead = t;
		}
	}

    public void PostTweet(int userId, int tweetId)
    {
        if (!UserMap.ContainsKey(userId))
        {
            var user = new User(userId);
            UserMap[userId] = user;
        }

        UserMap[userId].Post(tweetId);    
    }
    
    // Time complexity: O(k), where k - number of followees;
    public IList<int> GetNewsFeed(int userId)
    {
        var result = new List<int>();

        if (!UserMap.ContainsKey(userId))
            return result;

        var maxHeap = new PriorityQueue<Tweet, int>(Comparer<int>.Create((a, b) => b - a));

        var user = UserMap[userId];

        foreach (var followeeId in user.Followed)
        {
            var followeeExists = UserMap.TryGetValue(followeeId, out var followee);

            if (!followeeExists)
                continue;

            var tweet = followee.TweetHead;

            if (tweet != null)
                maxHeap.Enqueue(tweet, tweet.Time);
        }

        while (maxHeap.Count > 0 && result.Count < 10)
        {
            var recentTweet = maxHeap.Dequeue();
            result.Add(recentTweet.Id);

            if (recentTweet.Next != null)
                maxHeap.Enqueue(recentTweet.Next, recentTweet.Next.Time);
        }

        return result;
    }
    
    public void Follow(int followerId, int followeeId)
    {
        if (!UserMap.ContainsKey(followerId))
        {
            var user = new User(followerId);
            UserMap[followerId] = user;
        }

        UserMap[followerId].Follow(followeeId);    
    }
    
    public void Unfollow(int followerId, int followeeId)
    {
        if (!UserMap.ContainsKey(followerId))
        {
            var user = new User(followerId);
            UserMap[followerId] = user;
        }

        UserMap[followerId].Unfollow(followeeId);    
    }
}