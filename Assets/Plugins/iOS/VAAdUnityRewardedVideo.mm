//
//  VAAdUnityRewardedVideo.m
//  MyFirstVMFiveAdNetworkProject
//
//  Created by DaidoujiChen on 2016/7/26.
//  Copyright © 2016年 DaidoujiChen. All rights reserved.
//

#import "VAAdUnityRewardedVideo.h"
#import <objc/runtime.h>

extern "C" void UnitySendMessage(const char *, const char *, const char *);

@interface VAAdUnityRewardedVideo ()

@property (nonatomic, strong) VAAdRewardedVideo *rewardedVideo;
@property (nonatomic, assign) const char *(*customStringCallback)(const char*);

@end

@implementation VAAdUnityRewardedVideo

#pragma mark - VAAdRewardedVideoDelegate

- (void)rewardedVideoDidLoad:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoDidLoad", "");
    [self.rewardedVideo show];
}

- (void)rewardedVideoWillShow:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoWillShow", "");
}

- (void)rewardedVideoDidShow:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoDidShow", "");
}

- (void)rewardedVideoWillClose:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoWillClose", "");
}

- (void)rewardedVideoDidClose:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoDidClose", "");
}

- (void)rewardedVideoDidClick:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoDidClick", "");
}

- (void)rewardedVideoDidFinishHandlingClick:(VAAdRewardedVideo *)rewardedVideo {
    UnitySendMessage("adUnityRewardedVideoObject", "rewardedVideoDidFinishHandlingClick", "");
}

- (void)rewardedVideo:(VAAdRewardedVideo *)rewardedVideo shouldReward:(VAAdRewarded *)rewarded {
    UnitySendMessage("adUnityRewardedVideoObject", "shouldReward", "");
}

- (void)rewardedVideo:(VAAdRewardedVideo *)rewardedVideo didFailWithError:(NSError *)error {
    UnitySendMessage("adUnityRewardedVideoObject", "didFailWithError", error.description.UTF8String);
}

- (NSString *)rewardedCustomString {
    if ([VAAdUnityRewardedVideo shared].customStringCallback) {
        return [NSString stringWithFormat:@"%s", [VAAdUnityRewardedVideo shared].customStringCallback("")];
    }
    else {
        return @"";
    }
}

#pragma mark - Class Method

+ (instancetype)shared {
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        objc_setAssociatedObject(self, _cmd, [VAAdUnityRewardedVideo new], OBJC_ASSOCIATION_RETAIN_NONATOMIC);
    });
    return objc_getAssociatedObject(self, _cmd);
}

#pragma mark - Instance Method

- (void)initWithPlacement:(NSString *)placement isTestMode:(BOOL)testMode andAPIKey:(NSString *)apiKey {
    self.rewardedVideo = [[VAAdRewardedVideo alloc] initWithplacement:placement];
    self.rewardedVideo.testMode = testMode;
    self.rewardedVideo.apiKey = apiKey;
    self.rewardedVideo.delegate = self;
    [self.rewardedVideo loadAd];
}

@end

extern "C" {
    typedef const char *(*CustomStringCallback)(const char *);
    void _startWithPlacement(const char *placement, BOOL testMode, const char *apiKey);
    void _setRewardedCustomString(CustomStringCallback customStringCallback);
    void _echo(const char *echo);
}

void _startWithPlacement(const char *placement, BOOL testMode, const char *apiKey) {
    [VAAdUnityRewardedVideo shared].customStringCallback = nil;
    [[VAAdUnityRewardedVideo shared] initWithPlacement:[NSString stringWithFormat:@"%s", placement] isTestMode:testMode andAPIKey:[NSString stringWithFormat:@"%s", apiKey]];
}

void _setRewardedCustomString(CustomStringCallback customStringCallback) {
    [VAAdUnityRewardedVideo shared].customStringCallback = customStringCallback;
}

void _echo(const char *echo) {
    NSLog(@"%s", echo);
}
