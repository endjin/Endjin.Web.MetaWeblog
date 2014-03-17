namespace Endjin.Web.MetaWeblog.Mappers
{
    using System.Collections.Generic;
    using System.Globalization;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse;

    public class DeletionConfirmationToXmlRpcResponseMapper : IMapper<List<DeletionConfirmation>, Response>
    {
        public Response MapFrom(List<DeletionConfirmation> input)
        {
            var response = new Response();

            foreach (var deletionConfirmation in input)
            {
                response.Params.Add(new ResponseParams
                {
                    Param = new ResponseParam
                    {
                        Value = new MemberValue
                              {
                                  ValueChoice = MemberValue.ValueType.Boolean,
                                  Value = deletionConfirmation.Confirmation
                              },
                    }
                });
            }

            return response;
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((List<DeletionConfirmation>)input);
        }
    }
}