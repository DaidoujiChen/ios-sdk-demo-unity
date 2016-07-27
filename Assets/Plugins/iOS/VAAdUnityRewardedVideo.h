//
//  VAAdUnityRewardedVideo.h
//  MyFirstVMFiveAdNetworkProject
//
//  Created by DaidoujiChen on 2016/7/26.
//  Copyright © 2016年 DaidoujiChen. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "VMFiveAdNetwork.h"

@interface VAAdUnityRewardedVideo : NSObject <VAAdRewardedVideoDelegate>

+ (instancetype)shared;

- (void)initWithPlacement:(NSString *)placement isTestMode:(BOOL)testMode andAPIKey:(NSString *)apiKey;

@end
