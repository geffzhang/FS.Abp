import { CoreModule } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { NzTableListDirective } from './directives/nz-table-list.directive';
import { ExtensibleTableComponent } from './components/extensible-table/extensible-table.component';
import { GridActionsComponent } from './components/grid-actions/grid-actions.component';
import { PageToolbarComponent } from './components/page-toolbar/page-toolbar.component';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzDropDownModule } from 'ng-zorro-antd/dropdown';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzTableModule } from 'ng-zorro-antd/table';
import { UiExtensionsModule as AbpUiExtensionsModule } from '@abp/ng.theme.shared/extensions'
import { NgxValidateCoreModule } from '@ngx-validate/core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';

const declarationsWithExports = [
  ExtensibleTableComponent,
  GridActionsComponent,
  PageToolbarComponent,
  NzTableListDirective
];

const ZORRO_MODULES = [
  NzButtonModule,
  NzDropDownModule,
  NzIconModule,
  NzTableModule
];

@NgModule({
  exports: [
    ...declarationsWithExports,
    AbpUiExtensionsModule
  ],
  declarations: [
    ...declarationsWithExports
  ],
  imports: [
    CoreModule,
    ThemeSharedModule,
    NgxValidateCoreModule,
    AbpUiExtensionsModule,
    ...ZORRO_MODULES,
  ],
})
export class BaseUiExtensionsModule {}

@NgModule({
  exports: [BaseUiExtensionsModule],
  imports: [BaseUiExtensionsModule],
})
export class UiExtensionsModule {}