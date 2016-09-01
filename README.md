# Applause iOS SDK 串接 Unity 使用說明

這份文件可以幫助開發者快速的將 `Applause iOS SDK` 導入 `Unity` 專案中, 下面我們將以這幾個大項, 來一步步的完成

 * [事前準備](https://github.com/DaidoujiChen/ios-sdk-demo-unity/blob/master/README.md#事前準備)
 * [Unity 端設定](https://github.com/DaidoujiChen/ios-sdk-demo-unity/blob/master/README.md#unity-端設定)
 * [Xcode 端設定](https://github.com/DaidoujiChen/ios-sdk-demo-unity/blob/master/README.md#xcode-端設定)
 * [VAAdUnityRewardedVideo 使用說明](https://github.com/DaidoujiChen/ios-sdk-demo-unity/blob/master/README.md#vaadunityrewardedvideo-使用說明)


## 事前準備

  * 請先下載 `VAAdUnityRewardedVideo.unitypackage`

## Unity 端設定

### Import UnityPackage

畫面左下點擊右鍵選擇 `Assert` 資料夾, 選擇 `Import Package` -> `Custom Package...`
  
<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.07.png?token=AAo66U5WD9fCu20m0cqrqieRPNfJoNPPks5Xx9pBwA%3D%3D" width="593" height="476" />

選擇剛剛下載的檔案

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.23.png?token=AAo66WNJRbY8W5I8vpXln_2XhqzOFaodks5Xx9p-wA%3D%3D" width="570" height="74" />

### GameObject 設定

首先, 我們建立一個新的 `GameObject`, 從上方功能列選擇 `GameObject` -> `Create Empty`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.54.png?token=AAo66fm_22eVAwkHPSBzG8lhQrNxFjNvks5Xx9sNwA%3D%3D" width="483" height="454" />

接著, 我們會得到一個新的 `GameObject` 物件, 在畫面的右端, 我們可以看到一個 `Add Component` 按鈕, 點下他之後我們可以看到像是這樣的列表

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%883.21.31.png?token=AAo66XRtfaSoiGNCYxUDpc89J4Ivk9Zxks5Xx9tXwA%3D%3D" width="252" height="359" />

這邊我們先選擇 `Script` 使用我們建立好的 `Test Ad` 如下圖

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%883.21.40.png?token=AAo66YmpHUWlzvYbBOzIaNekjG0YSSenks5Xx9uJwA%3D%3D" width="246" height="168" />

到這邊, `Unity` 的部分就已經設定完成, 接下來, 我們點擊 `Command` + `Shift` + `B` 將專案輸出至 `Xcode` 格式
  
<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.47.30.png?token=AAo66TDEuhKReWt5_bEARmV8QSV2pFJ_ks5Xx9utwA%3D%3D" width="635" height="601" />

由於轉換成 `Xcode` 格式後, 我們還需要做一些調整, 所以選擇 `Build`, 而不是 `Build And Run`, 經過一些時間的等待, 我們可以得到一個 `Xcode` 的專案

## Xcode 端設定

建立完成後, 我們可以看到我們熟悉的 `Xcode` 專案圖示, 我們直接把他點開, `Xcode` 在這邊只有兩個部分需要調整, 一是在 `Build Settings` 中, 我們需要將 `bitcode` 的設定改為 `NO`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.49.28.png?token=AAo66VtU3BscNnFKhHNk936wUoqMUQ6kks5Xx9wlwA%3D%3D" width="599" height="144" />

二是將 `Other Linker Flags` 加入 `-ObjC`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.49.50.png?token=AAo66XF1DnlhCiyjQujts-21VjucHNxXks5Xx93TwA%3D%3D" width="666" height="423" />

設定完成後, 可以開始編譯, 如果沒有其他問題的話, 可以看見 `Applause` 的 `Reward Video` 廣告

## VAAdUnityRewardedVideo 使用說明

透過 C# 使用我們的 SDK 非常的容易, 初始化的方法為

`````C#
playAd(string placement, bool testMode, string apiKey);
`````

 * `placement` 為廣告的 placement
 * `testMode` 為 true 時為測試模式, false 時為正式模式
 * `apiKey` 從 `Applause` 取得的一組 key 值

其餘的部分則為廣告的 callback, 可以選擇需要的部分來做 implement

`````C#
// 廣告讀取完成, 即將開始播放
onRewardedVideoDidLoad();

// 廣告將要開始播放
onRewardedVideoWillShow();

// 廣告已經開始播放
onRewardedVideoDidShow();

// 廣告將要關閉
onRewardedVideoWillClose();

// 廣告已經關閉
onRewardedVideoDidClose();

// 廣告被點擊
onRewardedVideoDidClick();

// 點擊之後回到 app 的跳轉事件
onRewardedVideoDidFinishHandlingClick();

// 使用者看完影片, 可以得到獎勵
onShouldReward();

// 如果遇到錯誤, 則會收到錯誤訊息
onDidFailWithError();

// 如果有需要額外傳回給 server 的字串, 可以利用這個 function 帶回 callback
onSetRewardedCustomString();
`````

詳細的介接用法, 可以參考 `TestAd.cs`




  
