using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class VAAdUnityRewardedVideo : MonoBehaviour {

	// connect with objc code
	[DllImport("__Internal")]
	private static extern void _startWithPlacement(string placement, bool testMode, string apiKey);

	// shared instance
	private static readonly VAAdUnityRewardedVideo _shared = (new GameObject ("adUnityRewardedVideoObject")).AddComponent<VAAdUnityRewardedVideo>();
	private VAAdUnityRewardedVideo(){}
	public static VAAdUnityRewardedVideo shared {
		get {
			return _shared; 
		}
	}

	// private functions
	private void clearAllCallback() {
		_rewardedVideoDidLoad = null;
		_rewardedVideoWillShow = null;
		_rewardedVideoDidShow = null;
		_rewardedVideoWillClose = null;
		_rewardedVideoDidClose = null;
		_rewardedVideoDidClick = null;
		_rewardedVideoDidFinishHandlingClick = null;
		_shouldReward = null;
		_didFailWithError = null;
	}

	// init
	public void playAd(string placement, bool testMode, string apiKey) {
		clearAllCallback();
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_startWithPlacement(placement, testMode, apiKey);
		}
	}

	// define callback format
	public delegate void callbackFunction(string message);

	// callback rewardedVideoDidLoad
	private callbackFunction _rewardedVideoDidLoad;
	private void rewardedVideoDidLoad(string message) {
		if (_rewardedVideoDidLoad != null) {
			_rewardedVideoDidLoad(message);
		}
	}
	public void onRewardedVideoDidLoad(callbackFunction callback) {
		_rewardedVideoDidLoad = callback;
	}

	// callback rewardedVideoWillShow
	private callbackFunction _rewardedVideoWillShow;
	private void rewardedVideoWillShow(string message) {
		if (_rewardedVideoWillShow != null) {
			_rewardedVideoWillShow(message);
		}
	}
	public void onRewardedVideoWillShow(callbackFunction callback) {
		_rewardedVideoWillShow = callback;
	}

	// callback rewardedVideoDidShow
	private callbackFunction _rewardedVideoDidShow;
	private void rewardedVideoDidShow(string message) {
		if (_rewardedVideoDidShow != null) {
			_rewardedVideoDidShow(message);
		}
	}
	public void onRewardedVideoDidShow(callbackFunction callback) {
		_rewardedVideoDidShow = callback;
	}

	// callback rewardedVideoWillClose
	private callbackFunction _rewardedVideoWillClose;
	private void rewardedVideoWillClose(string message) {
		if (_rewardedVideoWillClose != null) {
			_rewardedVideoWillClose(message);
		}
	}
	public void onRewardedVideoWillClose(callbackFunction callback) {
		_rewardedVideoWillClose = callback;
	}

	// callback rewardedVideoDidClose
	private callbackFunction _rewardedVideoDidClose;
	private void rewardedVideoDidClose(string message) {
		if (_rewardedVideoDidClose != null) {
			_rewardedVideoDidClose(message);
		}
	}
	public void onRewardedVideoDidClose(callbackFunction callback) {
		_rewardedVideoDidClose = callback;
	}

	// callback rewardedVideoDidClick
	private callbackFunction _rewardedVideoDidClick;
	private void rewardedVideoDidClick(string message) {
		if (_rewardedVideoDidClick != null) {
			_rewardedVideoDidClick(message);
		}
	}
	public void onRewardedVideoDidClick(callbackFunction callback) {
		_rewardedVideoDidClick = callback;
	}

	// callback rewardedVideoDidFinishHandlingClick
	private callbackFunction _rewardedVideoDidFinishHandlingClick;
	private void rewardedVideoDidFinishHandlingClick(string message) {
		if (_rewardedVideoDidFinishHandlingClick != null) {
			_rewardedVideoDidFinishHandlingClick(message);
		}
	}
	public void onRewardedVideoDidFinishHandlingClick(callbackFunction callback) {
		_rewardedVideoDidFinishHandlingClick = callback;
	}

	// callback rewardedVideoDidFinishHandlingClick
	private callbackFunction _shouldReward;
	private void shouldReward(string message) {
		if (_shouldReward != null) {
			_shouldReward(message);
		}
	}
	public void onShouldReward(callbackFunction callback) {
		_shouldReward = callback;
	}

	// callback didFailWithError
	private callbackFunction _didFailWithError;
	private void didFailWithError(string message) {
		if (_didFailWithError != null) {
			_didFailWithError(message);
		}
	}
	public void onDidFailWithError(callbackFunction callback) {
		_didFailWithError = callback;
	}

}
