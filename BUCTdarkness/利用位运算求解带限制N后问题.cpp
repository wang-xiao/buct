// ����λ�����������Ƶ�N������
#include <cstdio>
#include <iostream>
#include <cstring>

using namespace std;

int sta[20]; // sta[i]��ʾ��i������ռ��λ�õ����룬λΪ1��ʾ������ռ��
int n, msk;
char s[20];
// depΪ��ǰ�У�dwnΪ��ռ��������dep���ϵ�ͶӰ��lft��rgtΪб��ֱ��ռ��������dep���ϵ�ͶӰ
int dfs(int dep, int dwn, int lft, int rgt) {
    if(dep >= n) return 1;
    int cur = ~(sta[dep] | dwn | lft | rgt) & msk; // ȡdep�п���λ�õ����룬& msk����������Чλ�����β��õĸ�λ1
    int p = cur & (- cur); // ȡ��ͷ���λ�����룬��cur����ͷ���λ��1������λ��0
    int ret = 0;
    while(p) {
        ret += dfs(dep + 1, dwn | p, (lft | p) << 1, (rgt | p) >> 1);
        cur ^= p; // ɾ����ͷ���λ
        p = cur & (- cur) & msk; // ȡ��һ���ɰڷ�λ��
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
