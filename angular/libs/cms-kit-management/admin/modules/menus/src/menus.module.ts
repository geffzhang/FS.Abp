import { NgModule } from '@angular/core';

import { CmsKitManagementSharedModule } from '@fs-tw/cms-kit-management/shared';

import { PickCoverImageModule } from '@fs-tw/components/pick-cover-image';
import { MenusComponent } from './components/menus/menus.component';
import { MenusRoutingModule } from './menus-routing.module';
import { TreeModule } from '@abp/ng.components/tree';
@NgModule({
  declarations: [MenusComponent],
  imports: [
    MenusRoutingModule,
    CmsKitManagementSharedModule,
    PickCoverImageModule,
    TreeModule
  ],
})
export class MenusModule {}
