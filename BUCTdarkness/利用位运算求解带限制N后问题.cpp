// 利用位运算求解带限制的N后问题
#include <cstdio>
#include <iostream>
#include <cstring>

using namespace std;

int sta[20]; // sta[i]表示第i行中已占用位置的掩码，位为1表示该列已占用
int n, msk;
char s[20];
// dep为当前行，dwn为列占用向量在dep行上的投影，lft和rgt为斜向直线占用向量在dep行上的投影
int dfs(int dep, int dwn, int lft, int rgt) {
    if(dep >= n) return 1;
    int cur = ~(sta[dep] | dwn | lft | rgt) & msk; // 取dep行可用位置的掩码，& msk用来保留有效位，屏蔽不用的高位1
    int p = cur & (- cur); // 取最低非零位的掩码，即cur的最低非零位置1，其他位置0
    int ret = 0;
    while(p) {
        ret += dfs(dep + 1, dwn | p, (lft | p) << 1, (rgt | p) >> 1);
        cur ^= p; // 删除最低非零位
        p = cur & (- cur) & msk; // 取下一个可摆放位置
    }
    return ret;
}

int main() {
    int cas = 0;
    while(scanf("%d", &n), n) {
        msk = (1 << n) - 1;
        for(int i=0; i<n; i++) {
            scanf("%s", s);
            sta[i] = 0;
            for(int j=0; s[j]; ++j) {
                if(s[j] == '*') {
                    sta[i] |= (1 << j);
                }
            }
        }
        printf("Case %d: %d\n", ++ cas, dfs(0, 0, 0, 0));
    }

    return 0;
}
