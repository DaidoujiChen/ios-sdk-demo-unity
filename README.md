# Applause iOS SDK 串接 Unity 使用說明

## 事前準備

  * 請先下載 `VAAdUnityRewardedVideo.unitypackage`

## Unity 端設定

### Import UnityPackage

畫面左下點擊右鍵選擇 `Assert` 資料夾, 選擇 `Import Package` -> `Custom Package...`
  
<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.07.png?token=AAo66TGZCWZmGQEN12U7NNKX3bn1Tdacks5XoZlVwA%3D%3D" width="593" height="476" />

選擇剛剛下載的檔案

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.23.png?token=AAo66cT5JSeKvvn8JZ371d_ay-SZOSAoks5XoZpCwA%3D%3D" width="570" height="74" />

### GameObject 設定

首先, 我們建立一個新的 `GameObject`, 從上方功能列選擇 `GameObject` -> `Create Empty`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.46.54.png?token=AAo66YeVX-0GxFKrNpCtb_DJMs3EXkd2ks5XoZrewA%3D%3D" width="483" height="454" />

接著, 我們會得到一個新的 `GameObject` 物件, 在畫面的右端, 我們可以看到一個 `Add Component` 按鈕, 點下他之後我們可以看到像是這樣的列表

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%883.21.31.png?token=AAo66TxXYH9mQXaP2nlhOuPQ6WaSTbH_ks5XoZxDwA%3D%3D" width="252" height="359" />

這邊我們先選擇 `Script` 使用我們建立好的 `Test Ad` 如下圖

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%883.21.40.png?token=AAo66SaqXzxtsLQXSIg9tYAT6_DIBoKSks5XoZ9kwA%3D%3D" width="246" height="168" />

到這邊, `Unity` 的部分就已經設定完成, 接下來, 我們點擊 `Command` + `Shift` + `B` 將專案輸出至 `Xcode` 格式
  
<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.47.30.png?token=AAo66Up03sHernaVPRYKYfdiGy3QrD-_ks5XoZ_8wA%3D%3D" width="635" height="601" />

由於轉換成 `Xcode` 格式後, 我們還需要做一些調整, 所以選擇 `Build`, 而不是 `Build And Run`, 經過一些時間的等待, 我們可以得到一個 `Xcode` 的專案

## Xcode 端設定

建立完成後, 我們可以看到我們熟悉的 `Xcode` 專案圖示, 我們直接把他點開, `Xcode` 在這邊只有兩個部分需要調整, 一是在 `Build Settings` 中, 我們需要將 `bitcode` 的設定改為 `NO`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.49.28.png?token=AAo66d6MtGbso5P8qQW878A-fd83lDb_ks5XoaGgwA%3D%3D" width="599" height="144" />

二是將 `Other Linker Flags` 加入 `-ObjC`

<img src="https://raw.githubusercontent.com/DaidoujiChen/ios-sdk-demo-unity/master/Images/%E8%9E%A2%E5%B9%95%E5%BF%AB%E7%85%A7%202016-07-27%20%E4%B8%8B%E5%8D%882.49.50.png?token=AAo66c-5hah3ckAuUJLQA7WQ-irhl3hLks5XoaIVwA%3D%3D" width="666" height="423" />

設定完成後, 可以開始編譯, 如果沒有其他問題的話, 可以看見 `Applause` 的 `Reward Video` 廣告






  
