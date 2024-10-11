class Program
{

	static void Main()
	{
		// Create a list of videos and add several videos. 
		List<Video> videos = new List<Video>();
		Video vid1 = new Video("This Truck is Going To Destroy the Road","Drv4Fun",12.5f);
		vid1.NewComment("@TrkLvr2303","I can't believe that made a truck that drive sideways while facing forward. Its Ridculous!!!");	
		vid1.NewComment("@Nemo","I love it, I want one now.  (Got talk to the wife).  Wish me luck. ");	
		vid1.NewComment("@SlmShdy","\"It can't climb trees, right...\"");	
		vid1.NewComment("@movovr","It looks good but for the price, I'll never buy one.");	
		
		videos.Add(vid1);
		Video vid2 = new Video("The Amazing Gadget Everyone is Talking About.","tchnerd0123",15.34f);
		vid2.NewComment("@mightythings@cake","I can't wait for the flying cars.");	
		vid2.NewComment("@icall","Your my favorite YouTuber.  Please keep the great content coming.");	
		vid2.NewComment("@calebscoothings","When I first saw this it looked like clickbait, but it is just a fancy lighter that can start your house on fire faster than an ordinary one.");	
		vid2.NewComment("@trumpit","they already have lighters and they are waaaaaaayy cheaper.  Just another usless invention.  Do you really need bluetooth for a lighter?");	
		videos.Add(vid2);
		
		Video vid3 = new Video("100 Identical Twins Fight For $250,000","MrBeast",35.67f);
		vid3.NewComment("@v_simxne","This was more like 98 identical twins and 2 karens");	
		vid3.NewComment("@OfficialCFrost","Next one should be 100 couples for 250k that would really test a relationship!");	
		vid3.NewComment("@metodijetrajanovski2852","The morris twins deserved it, they had the best coordination and didnt argue once.");	
		
		videos.Add(vid3);
		Video vid4 = new Video("Dude Perfect Headquarters is GONE!","Dude Perfect",27.88f);
		vid4.NewComment("@mbc1ty","Coby's first battle win not being on the top ten moments is criminal");	
		vid4.NewComment("@micahmirabella6597","No one can replace Ned!!");	
		vid4.NewComment("@boocaj","Seeing their growth as a team and a company over the years is super fascinating these dudes rock");	
		
		videos.Add(vid4);


		// Display the information of each video, such as the author, the title, the number of comments, and the length of the video.
		for(int i = 0;i < videos.Count();i++)
		{
			videos[i].DisplayInfo();
			Console.WriteLine();
		}
	}
	

}
