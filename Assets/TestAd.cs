using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TestAd : MonoBehaviour {

	[DllImport("__Internal")]
	private static extern void _echo(string placement);

	// handle all callbacks
	private void handleRewardedVideoDidLoad(string message) {
		_echo("handleRewardedVideoDidLoad");
	}

	private void handleRewardedVideoWillShow(string message) {
		_echo("handleRewardedVideoWillShow");
	}

	private void handleRewardedVideoDidShow(string message) {
		_echo("handleRewardedVideoDidShow");
	}

	private void handleRewardedVideoWillClose(string message) {
		_echo("handleRewardedVideoWillClose");
	}

	private void handleRewardedVideoDidClose(string message) {
		_echo("handleRewardedVideoDidClose");
	}

	private void handleRewardedVideoDidClick(string message) {
		_echo("handleRewardedVideoDidClick");
	}

	private void handleRewardedVideoDidFinishHandlingClick(string message) {
		_echo("handleRewardedVideoDidFinishHandlingClick");
	}

	private void handleShouldReward(string message) {
		_echo("handleShouldReward");
	}

	private void handleDidFailWithError(string message) {
		_echo("handleDidFailWithError");
	}

	void Start () {
		VAAdUnityRewardedVideo.shared.playAd("daidouji", true, "");
		VAAdUnityRewardedVideo.shared.onRewardedVideoDidLoad(handleRewardedVideoDidLoad);
		VAAdUnityRewardedVideo.shared.onRewardedVideoWillShow(handleRewardedVideoWillShow);
		VAAdUnityRewardedVideo.shared.onRewardedVideoDidShow(handleRewardedVideoDidShow);
		VAAdUnityRewardedVideo.shared.onRewardedVideoWillClose(handleRewardedVideoWillClose);
		VAAdUnityRewardedVideo.shared.onRewardedVideoDidClose(handleRewardedVideoDidClose);
		VAAdUnityRewardedVideo.shared.onRewardedVideoDidClick(handleRewardedVideoDidClick);
		VAAdUnityRewardedVideo.shared.onRewardedVideoDidFinishHandlingClick(handleRewardedVideoDidFinishHandlingClick);
		VAAdUnityRewardedVideo.shared.onShouldReward(handleShouldReward);
		VAAdUnityRewardedVideo.shared.onDidFailWithError(handleDidFailWithError);
	}

	void Update () {
	}

}
