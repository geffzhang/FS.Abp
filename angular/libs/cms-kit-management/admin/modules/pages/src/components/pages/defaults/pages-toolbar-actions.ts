import { ToolbarAction } from '@abp/ng.theme.shared/extensions';
import { Volo } from '@fs-tw/cms-kit-management/proxy/cms-kit';
import { notify } from '@fs-tw/theme-alain/extensions';

export const PAGES_TOOLBAR_ACTIONS = ToolbarAction.createMany<
  Volo.CmsKit.Admin.Pages.PageDto[]
>([
  {
    text: 'CmsKit::NewPage',
    action: notify('Create'),
    permission: 'CmsKit.Pages.Create',
    icon: 'fa fa-plus',
  },
]);
