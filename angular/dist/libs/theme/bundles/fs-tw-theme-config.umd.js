(function (global, factory) {
    typeof exports === 'object' && typeof module !== 'undefined' ? factory(exports, require('@angular/core'), require('@abp/ng.core')) :
    typeof define === 'function' && define.amd ? define('@fs-tw/theme/config', ['exports', '@angular/core', '@abp/ng.core'], factory) :
    (global = typeof globalThis !== 'undefined' ? globalThis : global || self, factory((global['fs-tw'] = global['fs-tw'] || {}, global['fs-tw'].theme = global['fs-tw'].theme || {}, global['fs-tw'].theme.config = {}), global.ng.core, global.ng_core));
}(this, (function (exports, core, ng_core) { 'use strict';

    // import { eThemesPolicyNames } from '../enums/policy-names';
    var THEME_ROUTE_PROVIDERS = [
        {
            provide: core.APP_INITIALIZER,
            useFactory: configureRoutes,
            deps: [ng_core.RoutesService],
            multi: true,
        },
    ];
    function configureRoutes(routes) {
        var shortcut = {
            path: '/theme',
            name: "Theme::Menu:Theme" /* Theme */,
            layout: "application" /* application */,
            parentName: "AbpUiNavigation::Menu:Administration" /* Administration */,
            iconClass: 'fa fa-folder-open',
            order: 6,
        };
        return function () {
            routes.add([
                shortcut
            ]);
        };
    }

    var ThemeConfigModule = /** @class */ (function () {
        function ThemeConfigModule() {
        }
        ThemeConfigModule.forRoot = function () {
            return {
                ngModule: ThemeConfigModule,
                providers: [THEME_ROUTE_PROVIDERS],
            };
        };
        return ThemeConfigModule;
    }());
    ThemeConfigModule.decorators = [
        { type: core.NgModule }
    ];

    // export * from './services';

    /**
     * Generated bundle index. Do not edit.
     */

    exports.THEME_ROUTE_PROVIDERS = THEME_ROUTE_PROVIDERS;
    exports.ThemeConfigModule = ThemeConfigModule;
    exports.configureRoutes = configureRoutes;
    exports.ɵa = THEME_ROUTE_PROVIDERS;
    exports.ɵb = configureRoutes;

    Object.defineProperty(exports, '__esModule', { value: true });

})));
//# sourceMappingURL=fs-tw-theme-config.umd.js.map