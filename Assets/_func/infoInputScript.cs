using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor;



public class infoInputScript : MonoBehaviour {
	public string username;
	private string password;
	public Text alert;
	void Start (){
		alert.text = "";
	}
	public void resetAlert(){
		alert.text = "";
	}

	public void UsernameInput(InputField usernameInput){
		username = usernameInput.text;

	}

	public void PasswordInput(InputField passwordInput){
		password = passwordInput.text;
	}

	public void login(){
		if (username=="admin" && password=="admin"){
			Application.LoadLevel("user");
		}else{
			alert.text = "Wrong username or password";
		}
	}

}
//http://wiki.unity3d.com/index.php?title=Server_Side_Highscores
//http://forum.unity3d.com/threads/starting-my-mmo-with-sql-server-in-javascript.77447/
//https://www.youtube.com/watch?v=Q5dCbuGzZow