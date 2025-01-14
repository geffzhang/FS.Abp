import { NgModule } from '@angular/core';
import { CoreModule } from '@abp/ng.core';
import { NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import { QuillModule } from 'ngx-quill';

import { BlogFeatureTabComponent } from './components/tabs/blog-feature-tab/blog-feature-tab.component';
import { MediaTabComponent } from './components/tabs/media-tab/media-tab.component';

import { NzUploadDefaultDirective } from './directives/nz-upload-default.directive';
import { NzUploadDefaultComponent } from './directives/nz-upload-default.component';

import { SHARED_ZORRO_MODULES } from './shared-zorro.module';
import { SHARED_DELON_MODULES } from './shared-delon.module';
import { SHARED_ABP_MODULES } from './shared-abp.module';
import { SHARED_FS_MODULES } from './shared-fs.module';

import { PageModule } from '@fs-tw/components/page';

let COMPONENT = [
  BlogFeatureTabComponent,
  MediaTabComponent,

  NzUploadDefaultDirective,
  NzUploadDefaultComponent,
];

@NgModule({
  declarations: [...COMPONENT],
  imports: [
    SHARED_ABP_MODULES,
    SHARED_ZORRO_MODULES,
    SHARED_FS_MODULES,
    QuillModule,
  ],
  exports: [
    SHARED_ZORRO_MODULES,
    SHARED_DELON_MODULES,
    SHARED_ABP_MODULES,
    SHARED_FS_MODULES,
    ...COMPONENT,
  ],
})
export class CmsKitManagementSharedModule {}
