import { ToolbarAction } from '@abp/ng.theme.shared/extensions';
import { Volo } from '@fs-tw/cms-kit-management/proxy/cms-kit';
import { notify } from '@fs-tw/theme-alain/extensions';

export const TAGS_ENTITY_ACTIONS = ToolbarAction.createMany<Volo.CmsKit.Tags.TagDto>(
  [
    {
      text: 'CmsKit::Edit',
      action: notify('Edit'),
    },
    {
      text: 'CmsKit::Delete',
      action: notify('Delete'),
    },
  ]
);
