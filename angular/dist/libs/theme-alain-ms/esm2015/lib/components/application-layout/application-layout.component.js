import { DOCUMENT } from '@angular/common';
import { Component, ElementRef, Inject, Renderer2, } from '@angular/core';
import { ActivatedRoute, NavigationEnd, NavigationError, RouteConfigLoadStart, Router, } from '@angular/router';
import { BreakpointObserver, MediaMatcher } from '@angular/cdk/layout';
import { LayoutStateService, } from '@fs-tw/theme-alain-ms/layout';
import { ReuseTabService } from '@delon/abc/reuse-tab';
import { updateHostClass } from '@delon/util';
import { NzMessageService } from 'ng-zorro-antd/message';
import { BrandService } from '@fs-tw/theme-alain-ms/layout';
export class ApplicationLayoutComponent {
    constructor(layoutStateService, bm, mediaMatcher, router, route, msg, reuseTabSrv, el, renderer, srv, doc) {
        this.layoutStateService = layoutStateService;
        this.router = router;
        this.route = route;
        this.msg = msg;
        this.el = el;
        this.renderer = renderer;
        this.srv = srv;
        this.doc = doc;
        //hasAllNav = false;
        //hasSidebar = true;
        this.isFetching = false;
        this.store$ = this.layoutStateService.getStore$();
        const routerData = Object.assign({ hasAllNav: false, hasSidebar: true }, route.snapshot.data);
        //this.hasAllNav = routerData.hasAllNav === true;
        //this.hasSidebar = routerData.hasSidebar === true;
        // scroll to top in change page
        router.events.subscribe((evt) => {
            if (!this.isFetching && evt instanceof RouteConfigLoadStart) {
                this.isFetching = true;
                this.scrollToTop();
            }
            if (evt instanceof NavigationError) {
                this.isFetching = false;
                msg.error(`无法加载${evt.url}路由`, { nzDuration: 1000 * 3 });
                return;
            }
            if (!(evt instanceof NavigationEnd)) {
                return;
            }
            this.isFetching = false;
            // If have already cached router, should be don't need scroll to top
            if (reuseTabSrv.exists(evt.url)) {
                return;
            }
            this.scrollToTop();
        });
        // media
        const query = {
            'screen-xs': '(max-width: 575px)',
            'screen-sm': '(min-width: 576px) and (max-width: 767px)',
            'screen-md': '(min-width: 768px) and (max-width: 991px)',
            'screen-lg': '(min-width: 992px) and (max-width: 1199px)',
            'screen-xl': '(min-width: 1200px)',
        };
        bm.observe([
            '(min-width: 1200px)',
            '(min-width: 992px) and (max-width: 1199px)',
            '(min-width: 768px) and (max-width: 991px)',
            '(min-width: 576px) and (max-width: 767px)',
            '(max-width: 575px)',
        ]).subscribe(() => {
            this.queryCls = Object.keys(query).find((key) => mediaMatcher.matchMedia(query[key]).matches);
            this.setClass();
        });
    }
    get isMobile() {
        return this.srv.isMobile;
    }
    get body() {
        return this.doc.body;
    }
    get isCurrentPath() {
        return this.router.createUrlTree(['./'], { relativeTo: this.route }).toString() === this.router.routerState.snapshot.url.toString();
    }
    get parentPath() {
        var _a, _b, _c, _d, _e, _f, _g, _h;
        var parentPath = (_e = (_d = (_c = (_b = (_a = this.layoutStateService) === null || _a === void 0 ? void 0 : _a.routesProcessor) === null || _b === void 0 ? void 0 : _b.CurrentRoute) === null || _c === void 0 ? void 0 : _c.parent) === null || _d === void 0 ? void 0 : _d.path) !== null && _e !== void 0 ? _e : "/";
        var parentPathLength = parentPath.split("/").length;
        var url = (_h = (_g = (_f = this.layoutStateService) === null || _f === void 0 ? void 0 : _f.routesProcessor) === null || _g === void 0 ? void 0 : _g.CurrentUrl) !== null && _h !== void 0 ? _h : "/";
        var urlArray = url.split("/").filter((x, i) => i < parentPathLength);
        return urlArray.toString().replace(/,/g, "/");
    }
    scrollToTop() {
        const el = this.doc.querySelector('.alain-ms__product-body');
        if (!el) {
            return;
        }
        el.scrollTop = 0;
    }
    setClass() {
        const { el, renderer, queryCls } = this;
        updateHostClass(el.nativeElement, renderer, {
            ['alain-ms']: true,
            [queryCls]: true,
        }, true);
    }
    setBodyClass() {
        const { hasTopbar, hasSidebar, hasFixed, colorWeak } = this.srv.layout;
        updateHostClass(this.body, this.renderer, {
            'color-weak': colorWeak,
            ['alain-ms__has-topbar']: hasTopbar,
            ['alain-ms__has-sidebar']: hasSidebar,
            ['alain-ms__has-fixed']: hasFixed,
        });
    }
    ngOnInit() {
        this.notify$ = this.srv.notify.subscribe(() => {
            this.setClass();
            this.setBodyClass();
        });
    }
    ngOnDestroy() {
        this.notify$.unsubscribe();
        this.body.classList.remove('alain-ms__has-topbar', 'alain-ms__has-sidebar', 'alain-ms__has-fixed');
    }
}
ApplicationLayoutComponent.decorators = [
    { type: Component, args: [{
                selector: 'abp-application-layout',
                template: "<ng-container *ngIf=\"store$ | async as store\">\r\n  <ms-topbar [allNav]=\"store.sidebarConfig.hasAllNav\"></ms-topbar>\r\n  <ms-sidebar *ngIf=\"store.sidebarConfig.hasSidebar\"></ms-sidebar>\r\n  <div class=\"brand-page-loading\" [hidden]=\"!store.isFetching\">\r\n    <nz-spin nzSpinning></nz-spin>\r\n  </div>\r\n  <div class=\"alain-ms__body\" [hidden]=\"store.isFetching\">\r\n    \r\n    <service-layout\r\n      [nav]=\"store.sidebarConfig.hasPageNav\"\r\n      [navConfig]=\"store.navConfig\"\r\n      [navList]=\"store.pageNavs\"\r\n    >\r\n      <!-- todo:move to feature module\r\n      <page-bar [subTitle]=\"subTitleTpl\" [title]=\"titleTpl\">\r\n        <ng-template #titleTpl> {{ store.navConfig.doc }} </ng-template>\r\n        <ng-template #subTitleTpl>\r\n          <div class=\"text-orange\">\r\n            \u4EE5\u4E0B\u53EA\u5C55\u793A\u90E8\u5206\u7EC4\u4EF6\uFF0C\u66F4\u591A\u7EC4\u4EF6<a\r\n              href=\"https://ng.ant.design\"\r\n              target=\"_blank\"\r\n              >ng.ant.design</a\r\n            >\r\n          </div>\r\n        </ng-template>\r\n        <button (click)=\"msg.success('clean')\" nz-button>\u6E05\u7406</button>\r\n        <button (click)=\"msg.success('remove')\" nz-button nzDanger>\u79FB\u9664</button>\r\n        <button (click)=\"msg.success('add')\" nz-button nzType=\"primary\">\r\n          \u65B0\u589E\r\n        </button>\r\n      </page-bar> -->\r\n      <div *ngTemplateOutlet=\"FsPageBar\"></div>\r\n      <router-outlet></router-outlet>\r\n    </service-layout>\r\n  </div>\r\n</ng-container>\r\n\r\n<ng-template #FsPageBar>\r\n  <page-bar [subTitle]=\"subTitleTpl\" [title]=\"titleTpl\">\r\n    <ng-template #subTitleTpl>\r\n      <span *ngIf=\"layoutStateService?.routesProcessor?.RouterState\" >\r\n        <button type=\"button\" class=\"pri-btn\" \r\n          *ngIf=\"!isCurrentPath\" \r\n          [routerLink]=\"[parentPath]\">\u8FD4\u56DE</button>\r\n      </span>\r\n    </ng-template>\r\n    <ng-template #titleTpl>\r\n      <span *ngIf=\"layoutStateService?.routesProcessor?.RouterState\">\r\n        {{layoutStateService?.routesProcessor?.CurrentRoute?.name | abpLocalization}}\r\n      </span>\r\n    </ng-template>\r\n  </page-bar>\r\n</ng-template>",
                styles: [".pri-btn{border:1px solid #ddd;color:#000;background:#fff;font-size:8px}.pri-btn:hover{border:1px solid #26d7eb;color:#26d7eb}"]
            },] }
];
ApplicationLayoutComponent.ctorParameters = () => [
    { type: LayoutStateService },
    { type: BreakpointObserver },
    { type: MediaMatcher },
    { type: Router },
    { type: ActivatedRoute },
    { type: NzMessageService },
    { type: ReuseTabService },
    { type: ElementRef },
    { type: Renderer2 },
    { type: BrandService },
    { type: undefined, decorators: [{ type: Inject, args: [DOCUMENT,] }] }
];
//# sourceMappingURL=application-layout.component.js.map