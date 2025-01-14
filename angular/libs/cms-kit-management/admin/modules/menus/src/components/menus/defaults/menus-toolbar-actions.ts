import { ToolbarAction } from '@abp/ng.theme.shared/extensions';
import { Volo } from '@fs-tw/cms-kit-management/proxy/cms-kit';
import { notify } from '@fs-tw/theme-alain/extensions';

export const MENUS_TOOLBAR_ACTIONS = ToolbarAction.createMany<
  Volo.CmsKit.Menus.MenuItemDto[]
>([
  {
    text: 'CmsKit::NewMenu',
    action: notify('Create'),
    icon: 'fa fa-plus',
  },
]);
