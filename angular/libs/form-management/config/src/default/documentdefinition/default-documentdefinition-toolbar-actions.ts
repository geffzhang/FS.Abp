import { ToolbarAction } from '@abp/ng.theme.shared/extensions';
import {Fs} from '@fs-tw/form-management/proxy';
import { eFormmanagementRouteNames } from '../../enums/route-names';
import { ExtensionsService } from '../../services/extensions.service';

export const DEFAULT_DOCUMENTDEFINITION_TOOLBAR_ACTIONS = ToolbarAction.createMany<
Fs.FormManagement.Documents.Dtos.DocumentDefinitionDto[]>([
  {
    text: '新增',
    action: data => {
      const service = data.getInjected(ExtensionsService);
      service.action(eFormmanagementRouteNames.DocumentDefinition, {
        name: 'Add'
      });
      //const component = data.getInjected(UsersComponent);
      //component.add();
    },
    //permission: 'AbpIdentity.Users.Create',
    icon: 'fa fa-plus',
  },
]);